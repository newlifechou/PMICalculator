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
    public partial class CalculatorPressureFromPDtoT : Form
    {
        public CalculatorPressureFromPDtoT()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double p,d;
                FormCommonOperate.ConvertStringToDouble(txtP1, out p);
                FormCommonOperate.ConvertStringToDouble(txtD1, out d);

                CalculatePressure cp = new CalculatePressure();
                cp.CalculateFromPDToT(p, d);
                txtT1.Text = cp.T2.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
