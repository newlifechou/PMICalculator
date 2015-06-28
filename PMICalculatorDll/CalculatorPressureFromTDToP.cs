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
    public partial class CalculatorPressureFromTDToP : Form
    {
        public string DataXMLFilePath;
        public CalculatorPressureFromTDToP()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double t, d;
                CommonOperate.ConvertStringToDouble(txtT1, out t);
                CommonOperate.ConvertStringToDouble(txtD1, out d);

                CalculatePressure cp = new CalculatePressure();
                cp.CalculateFromTDToP(t, d);
                txtP1.Text = cp.P1.ToString("N2");
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
