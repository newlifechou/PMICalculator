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
    public partial class CalculatorPressureFromTDToP : Form
    {
        public CalculatorPressureFromTDToP()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormCommonOperate.ClearAllTextBoxInForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double t, d;
                FormCommonOperate.ConvertStringToDouble(txtT1, out t);
                FormCommonOperate.ConvertStringToDouble(txtD1, out d);

                CalculatePressure cp = new CalculatePressure();
                cp.CalculateFromTDToP(t, d);
                txtP1.Text = cp.P1.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
