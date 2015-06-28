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
    public partial class CalculatorPressureFromT1D1D2ToT2 : Form
    {
        public string DataXMLFilePath;
        public CalculatorPressureFromT1D1D2ToT2()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double t1, d1, d2;
                CommonOperate.ConvertStringToDouble(txtT1, out t1);
                CommonOperate.ConvertStringToDouble(txtD1, out d1);
                CommonOperate.ConvertStringToDouble(txtD2, out d2);

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

        private void btnInventoryMold1_Click(object sender, EventArgs e)
        {
            InventoryMold im = new InventoryMold();
            im.DataXMLFilePath = DataXMLFilePath;
            im.FillIn += im_FillIn;

            Button btn = sender as Button;
            ButtonName = btn.Name;
            im.ShowDialog();
        }
        /// <summary>
        /// 区分按下去的是那个模具库按钮
        /// </summary>
        private string ButtonName;
        private void im_FillIn(object sender, InventoryArgs e)
        {
            if (ButtonName == "btnInventoryMold1")
            {
                txtD1.Text = e.Para1;
            }
            else if (ButtonName == "btnInventoryMold2")
            {
                txtD2.Text = e.Para1;
            }

        }
    }
}
