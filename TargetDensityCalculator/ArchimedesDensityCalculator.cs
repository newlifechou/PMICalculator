using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TargetDensityCalculator
{
    public partial class ArchimedesDensityCalculator : Form
    {
        public ArchimedesDensityCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, w1, w2, thereticaldensity;
                //当所有的textbox都转换成功的时候，才可以进行计算
                if (double.TryParse(txtWeight.Text, out weight) && double.TryParse(txtW1.Text, out w1) &&
                    double.TryParse(txtW2.Text, out w2) && double.TryParse(txtTheoreticalDensity.Text, out thereticaldensity))
                {
                    TargetDensityCalculate tdc = new TargetDensityCalculate();
                    try
                    {
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
                else
                {
                    throw new Exception("所有输入必须是数字！");
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
            FormOperate.ClearAllTextBoxInForm(this);
        }
    }
}
