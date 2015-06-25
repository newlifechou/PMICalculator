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
    public partial class CostMaterialsProcess : Form
    {
        public event EventHandler<CostCalculatorArgs> FillIn;
        public CostMaterialsProcess()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (FillIn != null)
            {
                decimal RawMaterial, Sintering, Others;
                RawMaterial = Sintering = Others = 0;
                if (decimal.TryParse(txtRawMaterial.Text, out RawMaterial) &&
                    decimal.TryParse(txtSintering.Text, out Sintering) &&
                   decimal.TryParse(txtOthers.Text, out Others))
                {
                    CostCalculatorArgs args = new CostCalculatorArgs();
                    args.CostValue = RawMaterial + Sintering + Others;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(label1.Text);
                    sb.AppendLine(RawMaterial.ToString("N2"));
                    sb.Append(label2.Text);
                    sb.AppendLine(Sintering.ToString());
                    sb.Append(label3.Text);
                    sb.Append(Others.ToString());
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

        private void CostMaterialsProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
