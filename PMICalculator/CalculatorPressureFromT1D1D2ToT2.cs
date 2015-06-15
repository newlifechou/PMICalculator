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
    public partial class CalculatorPressureFromT1D1D2ToT2 : Form
    {
        public CalculatorPressureFromT1D1D2ToT2()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double t1, d1, d2;
                FormCommonOperate.ConvertStringToDouble(txtT1, out t1);
                FormCommonOperate.ConvertStringToDouble(txtD1, out d1);
                FormCommonOperate.ConvertStringToDouble(txtD2, out d2);

                CalculatePressure cp = new CalculatePressure();
                cp.CalculateFromT1D1D2ToT2(d1, d2, t1);
                txtT2.Text = cp.T2.ToString("N2");
                txtP1.Text = cp.P1.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormCommonOperate.ClearAllTextBoxInForm(this);
        }
    }
}
