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
            txtUnitCostVHPProcess.Text = Properties.Settings.Default.UnitCostVHP.ToString("N2");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FillIn != null)
            {
                decimal unitPrice = 0;
                double deviceTime = 0;
                if (decimal.TryParse(txtUnitCostVHPProcess.Text, out unitPrice) && double.TryParse(txtDeviceTime.Text, out deviceTime))
                {
                    CostCalculatorArgs args = new CostCalculatorArgs();
                    args.CostValue = unitPrice * (decimal)deviceTime;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UnitCost:");
                    sb.Append(unitPrice.ToString("N2"));
                    sb.AppendLine("RMB/Device/Time");
                    sb.Append("Device*Time");
                    sb.Append(deviceTime.ToString());
                    sb.Append("Device*Time");
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
