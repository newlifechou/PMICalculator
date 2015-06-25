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
    public partial class CostVHPProcess : Form
    {
        public event EventHandler<CostCalculatorArgs> FillIn;
        public CostVHPProcess()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }
        private void CostVHPProcess_Load(object sender, EventArgs e)
        {
            txtUnitCost.Text = Properties.Settings.Default.UnitCostVHP.ToString("N2");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FillIn != null)
            {
                decimal unitPrice = 0;
                double CalcNumber = 0;
                if (decimal.TryParse(txtUnitCost.Text, out unitPrice) && double.TryParse(txtCalcNumber.Text, out CalcNumber))
                {
                    CostCalculatorArgs args = new CostCalculatorArgs();
                    args.CostValue = unitPrice * (decimal)CalcNumber;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(label1.Text);
                    sb.AppendLine(unitPrice.ToString("N2"));
                    sb.Append(label2.Text);
                    sb.Append(CalcNumber.ToString());
                    args.Remark = sb.ToString();
                    FillIn(this, args);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("All Input must be numbers");
                }
            }
        }
    }
}
