using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculatorDll
{
    public partial class CalculatorRectangleTargetDensity : Form
    {
        public CalculatorRectangleTargetDensity()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, width, height, h1, h2, h3, h4, h, theoreticalDensity;
                FormCommonOperate.ConvertStringToDouble(txtWeight, out weight);
                FormCommonOperate.ConvertStringToDouble(txtWidth, out width);
                FormCommonOperate.ConvertStringToDouble(txtHeight, out height);
                FormCommonOperate.ConvertStringToDouble(txtThickness1, out h1);
                FormCommonOperate.ConvertStringToDouble(txtThickness2, out h2);
                FormCommonOperate.ConvertStringToDouble(txtThickness3, out h3);
                FormCommonOperate.ConvertStringToDouble(txtThickness4, out h4);
                FormCommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out theoreticalDensity);
                try
                {
                    h=(h1 + h2 + h3 + h4) / 4;
                    this.txtThickness.Text = h.ToString("N2");

                    CalculateTargetDensity tdc = new CalculateTargetDensity();
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


    }
}
