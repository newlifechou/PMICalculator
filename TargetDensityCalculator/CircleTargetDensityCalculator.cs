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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
