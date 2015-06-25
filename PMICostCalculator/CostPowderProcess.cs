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
    public partial class CostPowderProcess : Form
    {
        public event EventHandler<CostCalculatorArgs> FillIn;
        public CostPowderProcess()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }
        private void CostPowderProcess_Load(object sender, EventArgs e)
        {
            txtUnitCostPowderProcess.Text = Properties.Settings.Default.UnitCostPowderProcess.ToString("N2");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FillIn!=null)
            {
                decimal unitPrice = 0;
                double powderWeight = 0;
                if (decimal.TryParse(txtUnitCostPowderProcess.Text, out unitPrice)&&double.TryParse(txtPowderWeight.Text,out powderWeight))
                {
                    CostCalculatorArgs args = new CostCalculatorArgs();
                    args.CostValue = unitPrice * (decimal)powderWeight;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UnitCost(RMB/kg):");
                    sb.AppendLine(unitPrice.ToString("N2"));
                    sb.Append("PowderWeight(kg):");
                    sb.Append(powderWeight.ToString());
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
