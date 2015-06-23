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
    public partial class NewCostCalcuate : Form
    {
        public NewCostCalcuate()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }
        /// <summary>
        /// 通过这个事件操作主窗体的数据加载
        /// </summary>
        public event EventHandler<NewCalcualteSheetEventArgs> New;

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCostCalcualteName.Text))
                {
                    //TODO:后面切换语言的时候要考虑
                    throw new Exception("名称不能为空");
                }
                //TODO:这里要检测是否和已有保存的文件文件名冲突


                //触发事件
                if (New!=null)
                {
                    NewCalcualteSheetEventArgs args = new NewCalcualteSheetEventArgs();
                    args.CostCalculateName = txtCostCalcualteName.Text;
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
