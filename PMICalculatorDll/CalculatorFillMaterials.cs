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
        public string DataXMLFilePath;
        public CalculatorFillMaterials()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
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
            txtDiameter.Text = e.Para1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
