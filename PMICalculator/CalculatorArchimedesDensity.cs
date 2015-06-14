using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculator
{
    public partial class CalculatorArchimedesDensity : Form
    {
        public CalculatorArchimedesDensity()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, w1, w2, thereticaldensity;
                //当所有的textbox都转换成功的时候，才可以进行计算
                FormCommonOperate.ConvertStringToDouble(txtWeight, out weight);
                FormCommonOperate.ConvertStringToDouble(txtW1, out w1);
                FormCommonOperate.ConvertStringToDouble(txtW2, out w2);
                FormCommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out thereticaldensity);

                try
                {
                    CalculateTargetDensity tdc = new CalculateTargetDensity();
                    tdc.CalculateArchimedeTargetDensity(weight, w1, w2, thereticaldensity);
                    txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                    txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");
                }
                catch (Exception ex)
                {
                    //将错误继续抛出，让最外层的trycatch来处理
                    throw ex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 清空Textbox操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            FormCommonOperate.ClearAllTextBoxInForm(this);
        }
    }
}
