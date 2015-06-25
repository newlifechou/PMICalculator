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
    public partial class CostMachiningProcess : Form
    {
        public event EventHandler<CostCalculatorArgs> FillIn;
        public CostMachiningProcess()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }

        private void CostMachiningProcess_Load(object sender, EventArgs e)
        {
            txtUnitCostMachining.Text = Properties.Settings.Default.UnitCostMachine.ToString("N2");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FillIn != null)
            {
                decimal unitPrice = 0;
                double pieces = 0;
                if (decimal.TryParse(txtUnitCostMachining.Text, out unitPrice) && double.TryParse(txtPowderPieces.Text, out pieces))
                {
                    CostCalculatorArgs args = new CostCalculatorArgs();
                    args.CostValue = unitPrice * (decimal)pieces;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UnitCost(RMB/Pieces):");
                    sb.AppendLine(unitPrice.ToString("N2"));
                    sb.Append("Pieces Of Targets:");
                    sb.Append(pieces.ToString());
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
