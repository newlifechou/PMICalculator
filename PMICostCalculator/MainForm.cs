using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    public partial class MainForm : Form
    {
        private CostCalculateSheet currentCostCalculateItem;
        private bool IsSaved; 

        public MainForm()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, true);
            //初始化
            IsSaved = true;
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCostCalcuate f = new NewCostCalcuate();
            f.New += f_New;
            f.ShowDialog();
        }

        private void f_New(object sender, NewCalcualteEventArgs e)
        {
            currentCostCalculateItem = new CostCalculateSheet(e.CostCalculateName);

            CostCalculateItem tmp = new CostCalculateItem();
            tmp.ItemName = "150619_SJ";
            tmp.ItemCost = 5000;
            tmp.ItemRemark = "暂时让三杰熔炼一部分";
            tmp.ItemType = CostCalculateType.Product;
            currentCostCalculateItem.MaterialsCosts = new List<CostCalculateItem>();
            currentCostCalculateItem.MaterialsCosts.Add(tmp);

            txtCostCaculateName.Text = currentCostCalculateItem.CostCalculateName;
            dgvMaterialsCost.DataSource = null;
            dgvMaterialsCost.DataSource = currentCostCalculateItem.MaterialsCosts;
            IsSaved = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCostCalcuate f = new OpenCostCalcuate();
            f.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果还没有保存当前计算表
            if (!IsSaved)
            {
                MessageBox.Show("尚未保存当前计算表，是否保存?");
                //TODO:这里添加保存计算表的代码
            }
        }



    }
}
