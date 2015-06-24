using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PMICostCalculator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 当前成本计算表
        /// </summary>
        private CostCalculationSheet CurrentCalculateSheet;
        /// <summary>
        /// 当前文件是否保存Flag
        /// </summary>
        private bool IsSaved;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.dgvCostCalculateList.AutoGenerateColumns = false;

            //初始化
            IsSaved = true;
        }
        
        /// <summary>
        /// 建立新的成本计算表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckCalculateSheetSave())
            {
                return;
            }
            NewCostCalcuationSheet f = new NewCostCalcuationSheet();
            f.New += f_New;
            f.ShowDialog();
        }
        private void f_New(object sender, CostCalcualtionSheetEventArgs e)
        {
            //初始化当前计算表
            CurrentCalculateSheet = new CostCalculationSheet(e.CalcualteSheetFileName);
            //CreateTestData();
            LoadCurrentCostSheetData();
        }
        /// <summary>
        /// 判断当前计算表是否保存
        /// <returns>是否取消关闭窗口e.cancel</returns>
        /// </summary>
        private bool CheckCalculateSheetSave()
        {
            //建立前判断当前的成本计算表是否已经保存
            if (!IsSaved)
            {
                DialogResult dr = MessageBox.Show("当前成本计算表还没有保存，是否保存？",
                    "保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    return true;
                }
                else if (dr == DialogResult.Yes)
                {
                    SaveCurrentCostSheet();
                }
            }
            return false;
        }
        /// <summary>
        /// 加载当前计算表到窗体
        /// </summary>
        private void LoadCurrentCostSheetData()
        {
            txtCostCaculateName.Text = CurrentCalculateSheet.SheetName;
            ReLoadDgv();
        }

        /// <summary>
        ///TODO:临时的数据生成器，过后删除
        /// </summary>
        //private void CreateTestData()
        //{
        //    Random r = new Random();
        //    for (int i = 0; i < 15; i++)
        //    {
        //        CostCalculateItem cci = new CostCalculateItem();
        //        cci.ItemName = "1506" + r.Next(10, 99) + "_SJ";
        //        switch (r.Next(10, 99) % 5)
        //        {
        //            case 0:
        //                cci.ItemType = CostCalculateType.MaterialsCost;
        //                cci.ItemStyle = CostCalculateStyle.Product;
        //                break;
        //            case 1:
        //                cci.ItemType = CostCalculateType.PowderProcessCost;
        //                cci.ItemStyle = CostCalculateStyle.Product;
        //                break;
        //            case 2:
        //                cci.ItemType = CostCalculateType.VHPCost;
        //                cci.ItemStyle = CostCalculateStyle.Experiement;
        //                break;
        //            case 3:
        //                cci.ItemType = CostCalculateType.MachineCost;
        //                cci.ItemStyle = CostCalculateStyle.Product;
        //                break;
        //            case 4:
        //                cci.ItemType = CostCalculateType.PackageCost;
        //                cci.ItemStyle = CostCalculateStyle.Experiement;
        //                break;
        //            default:
        //                cci.ItemType = CostCalculateType.BondingCost;
        //                cci.ItemStyle = CostCalculateStyle.Experiement;
        //                break;
        //        }
        //        cci.ItemCost = r.Next(1000, 9999);
        //        cci.ItemRemark = "三杰提供原料" + r.Next(10, 99);
        //        CurrentCalculateSheet.CostCalculateSheetList.Add(cci);
        //    }
        //}

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckCalculateSheetSave())
            {
                return;
            }
            OpenCostCalcuationSheet f = new OpenCostCalcuationSheet();
            f.OpenDoc += f_OpenDoc;
            f.ShowDialog();
        }

       private  void f_OpenDoc(object sender, CostCalcualtionSheetEventArgs e)
        {
            try
            {
                XMLDocOp doc = new XMLDocOp();
                string fileName = e.CalcualteSheetFileName;
                CurrentCalculateSheet = doc.Read(fileName);

                LoadCurrentCostSheetData();
                //设置为已经保存
                SetCurrentCalculateSheetSaved();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果还没有保存当前计算表
            e.Cancel = CheckCalculateSheetSave();
        }

        private void btnDelCost_Click(object sender, EventArgs e)
        {
            if (HasNoCurrentCalcualteSheet())
            {
                return;
            }

            if (dgvCostCalculateList.SelectedRows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("确定要删除选定计算项?", "确定删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string ItemName = dgvCostCalculateList.CurrentRow.Cells[0].Value.ToString();
            int deleteIndex = CurrentCalculateSheet.CostCalculateSheetList.FindIndex(i => i.ItemName == ItemName);
            CurrentCalculateSheet.CostCalculateSheetList.RemoveAt(deleteIndex);
            ReLoadDgv();
        }
        /// <summary>
        /// 设置当前计算表为未保存状态
        /// </summary>
        private void SetCurrentCalculateSheetNotSaved()
        {
            IsSaved = false;
            this.Text = "PMICostCalculator " + "-Not Saved";
        }
        /// <summary>
        /// 设置当前计算表为保存状态
        /// </summary>
        private void SetCurrentCalculateSheetSaved()
        {
            IsSaved = true;
            this.Text = "PMICostCalculator " + "-Saved";
        }
        /// <summary>
        /// 重新加载数据到dgv
        /// </summary>
        private void ReLoadDgv()
        {
            dgvCostCalculateList.DataSource = null;
            SetCurrentCalculateSheetNotSaved();
            //如果数据列表=0，跳过加载数据操作
            if (CurrentCalculateSheet.CostCalculateSheetList.Count==0)
            {
                return;
            }
            CurrentCalculateSheet.CostCalculateSheetList.Sort();
            dgvCostCalculateList.DataSource = CurrentCalculateSheet.CostCalculateSheetList;
            //dgvCostCalculateList.Refresh();
            CalculateTotal();
        }

        //计算总成本
        private void CalculateTotal()
        {
            decimal sum = 0;
            foreach (var item in CurrentCalculateSheet.CostCalculateSheetList)
            {
                sum += item.ItemCost;
            }
            txtTotalCost.Text = sum.ToString("N2");
        }
        /// <summary>
        /// 检查当前计算表是否存在
        /// </summary>
        private bool HasNoCurrentCalcualteSheet()
        {
            return CurrentCalculateSheet == null;
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            if (HasNoCurrentCalcualteSheet())
            {
                return;
            }
            AddCostItem f = new AddCostItem();
            f.AddCostCalculateItemEvent += f_AddCostCalculateItemEvent;
            f.ShowDialog();
        }

        private void f_AddCostCalculateItemEvent(object sender, NewCostItemEventArgs e)
        {
            //检测项目名称是否和已经存在的重名
            foreach (var item in CurrentCalculateSheet.CostCalculateSheetList)
            {
                if (item.ItemName==e.CostItem.ItemName)
                {
                    MessageBox.Show("ItemName must be different from those already exist");
                    return;
                }
            }
            CurrentCalculateSheet.CostCalculateSheetList.Add(e.CostItem);
            ReLoadDgv();
        }

        private void btnViewBrief_Click(object sender, EventArgs e)
        {
            if (HasNoCurrentCalcualteSheet())
            {
                return;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentCostSheet();
        }

        /// <summary>
        /// 保存当前的计算表
        /// </summary>
        private void SaveCurrentCostSheet()
        {
            if (!IsSaved)
            {
                try
                {
                    XMLDocOp doc = new XMLDocOp();
                    string fileName = Path.Combine(Environment.CurrentDirectory, Properties.Settings.Default.WorkingDirectory, CurrentCalculateSheet.SheetName + ".xml");
                    doc.Save(fileName, CurrentCalculateSheet);
                    MessageBox.Show("保存成功");
                    SetCurrentCalculateSheetSaved();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PMICostCalcualtor\r\nWelcome to use","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /// <summary>
        /// 切换界面语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageSwitch(object sender, EventArgs e)
        {
            ToolStripMenuItem CurrentItem = sender as ToolStripMenuItem;

            foreach (var item in languageToolStripMenuItem.DropDownItems)
            {
                ToolStripMenuItem TmpItem = item as ToolStripMenuItem;
                if (TmpItem.Name == CurrentItem.Name)
                {
                    TmpItem.Checked = true;
                }
                else
                {
                    TmpItem.Checked = false;
                }
            }
        }
    }
}
