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
    public partial class RectangleTargetDensityCalculator : Form
    {
        public RectangleTargetDensityCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormOperate.ClearAllTextBoxInForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, width, height, h, theoreticalDensity;
                FormOperate.ConvertStringToDouble(txtWeight, out weight);
                FormOperate.ConvertStringToDouble(txtWidth, out width);
                FormOperate.ConvertStringToDouble(txtHeight, out height);
                FormOperate.ConvertStringToDouble(txtThickness, out h);
                FormOperate.ConvertStringToDouble(txtTheoreticalDensity, out theoreticalDensity);
                try
                {
                    TargetDensityCalculate tdc = new TargetDensityCalculate();
                    tdc.CalculateRectangleTargetTargetDensity(weight, width, height, h, theoreticalDensity);
                    txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                    txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");
                }
                catch (Exception ex)
                {                 
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 实时计算出平均厚度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtThickness1_TextChanged(object sender, EventArgs e)
        {
            double h1, h2, h3, h4;
            try
            {
                FormOperate.ConvertStringToDouble(txtThickness1, out h1);
                FormOperate.ConvertStringToDouble(txtThickness2, out h2);
                FormOperate.ConvertStringToDouble(txtThickness3, out h3);
                FormOperate.ConvertStringToDouble(txtThickness4, out h4);
                this.txtThickness.Text = ((h1 + h2 + h3 + h4) / 4).ToString("N2");
            }
            catch (Exception)
            {
                this.txtThickness.Text = "-";
            }
        }
    }
}
