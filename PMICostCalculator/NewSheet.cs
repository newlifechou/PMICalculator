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
    public partial class NewSheet : Form
    {
        public NewSheet()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }
        /// <summary>
        /// 通过这个事件操作主窗体的数据加载
        /// </summary>
        public event EventHandler<CostCalculationSheetEventArgs> New;

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //检验文件名是否合法
                if (!FileOperate.IsValideFileName(txtCostCalcualteName.Text))
                {
                    throw new Exception("The Name must be illeage");
                }
                //检测是否和已有保存的文件文件名冲突
                if (FileOperate.IsFileAlreadyExist(txtCostCalcualteName.Text,Properties.Settings.Default.WorkingDirectory))
                {
                    throw new Exception("Same name files exsit, change another name");
                }
                //触发事件
                if (New!=null)
                {
                    CostCalculationSheetEventArgs args = new CostCalculationSheetEventArgs();
                    args.CalcualteSheetFileName = txtCostCalcualteName.Text;
                    args.Remark = txtRemark.Text;
                    New(this,args);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
