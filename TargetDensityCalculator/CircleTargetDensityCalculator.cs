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
    public partial class CircleTargetDensityCalculator : Form
    {
        public CircleTargetDensityCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormOperate.ClearAllTextBoxInForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, diameter, h1, h2, h3, h4, h,paperWeight, paperThickness, theoreticalDensity;
                FormOperate.ConvertStringToDouble(txtWeight, out weight);
                FormOperate.ConvertStringToDouble(txtDiameter, out diameter);
                FormOperate.ConvertStringToDouble(txtThickness1, out h1);
                FormOperate.ConvertStringToDouble(txtThickness2, out h2);
                FormOperate.ConvertStringToDouble(txtThickness3, out h3);
                FormOperate.ConvertStringToDouble(txtThickness4, out h4);
                FormOperate.ConvertStringToDouble(txtTheoreticalDensity, out theoreticalDensity);
                h= (h1 + h2 + h3 + h4) / 4;
                this.txtThickness.Text = h.ToString("N2");
                //如果需要减去石墨纸的重量和厚度
                if (chkIncludeCarbonPaper.Checked == true)
                {
                    FormOperate.ConvertStringToDouble(txtPaperThickness, out paperThickness);
                    FormOperate.ConvertStringToDouble(txtPapterWeight, out paperWeight);

                    h = h - paperThickness;
                    this.txtMovePaperThickness.Text = h.ToString("N2");
                    weight = weight - paperWeight;
                    this.txtMovePaperWeight.Text = weight.ToString("N2");
                }

                TargetDensityCalculate tdc = new TargetDensityCalculate();
                tdc.CalculateCirlcleTargetDensity(weight, diameter, h, theoreticalDensity);
                txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkIncludeCarbonPaper_CheckedChanged(object sender, EventArgs e)
        {
            txtPapterWeight.Enabled = chkIncludeCarbonPaper.Checked;
            txtPaperThickness.Enabled = chkIncludeCarbonPaper.Checked;
            panelMovePaper.Visible = chkIncludeCarbonPaper.Checked;
        }
    }
}
