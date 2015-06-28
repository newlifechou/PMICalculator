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
    public partial class CalculatorFillMaterials : Form
    {
        public string DataXMLFilePathMold;
        public string DataXMLFilePathDensity;
        public CalculatorFillMaterials()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnInventoryMold_Click(object sender, EventArgs e)
        {
            InventoryMold im = new InventoryMold();
            im.DataXMLFilePath = DataXMLFilePathMold;
            im.FillIn += im_FillIn;
            im.ShowDialog();
        }

        private void im_FillIn(object sender, InventoryArgs e)
        {
            txtDiameter.Text = e.Para1;
        }

        private void btnInventoryDensity_Click(object sender, EventArgs e)
        {
            InventoryDensity id = new InventoryDensity();
            id.DataXMLFilePath = DataXMLFilePathDensity;
            id.FillPath += id_FillPath;
            id.ShowDialog();
        }

        private void id_FillPath(object sender, InventoryArgs e)
        {
            txtTheoreticalDensity.Text = e.Para2;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double density, d, h1, h2, number,weight;
            try
            {
                CommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out density);
                CommonOperate.ConvertStringToDouble(txtDiameter, out d);
                CommonOperate.ConvertStringToDouble(txtThickness, out h1);
                if (chkThicknessMore.Checked)
                {
                    CommonOperate.ConvertStringToDouble(txtThicnessMore, out h2);
                    h1 += h2;
                }
                CommonOperate.ConvertStringToDouble(txtNumber, out number);
                weight = Math.PI * d * d * h1 / 4000 * density * number;
                txtTotal.Text = weight.ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
