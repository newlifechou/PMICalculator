using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculatorDll
{
    public partial class CalculatorPressureFromPDtoT : Form
    {
        public string DataXMLFilePath;
        public CalculatorPressureFromPDtoT()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double p, d;
                CommonOperate.ConvertStringToDouble(txtP1, out p);
                CommonOperate.ConvertStringToDouble(txtD1, out d);

                CalculatePressure cp = new CalculatePressure();
                cp.CalculateFromPDToT(p, d);
                txtT1.Text = cp.T2.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInventoryMold_Click(object sender, EventArgs e)
        {
            InventoryMold im = new InventoryMold();
            im.DataXMLFilePath = DataXMLFilePath;
            im.FillIn += im_FillIn;
            im.ShowDialog();
        }

        private void im_FillIn(object sender, InventoryArgs e)
        {
            txtD1.Text = e.Para1;
        }
    }
}
