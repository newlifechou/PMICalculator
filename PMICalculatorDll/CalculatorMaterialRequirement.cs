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
    public partial class CalculatorMaterialRequirement : Form
    {
        public string DataXMLFilePathMold;
        public string DataXMLFilePathDensity;
        public CalculatorMaterialRequirement()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnInventoryMold_Click(object sender, EventArgs e)
        {
            InventoryMold IM = new InventoryMold();
            IM.DataXMLFilePath = DataXMLFilePathMold;
            IM.FillIn += IM_FillIn;
            IM.ShowDialog();
        }

        private void IM_FillIn(object sender, InventoryArgs e)
        {
            txtMoldDiameter.Text = e.Para1;
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
            txtDensity.Text = e.Para2;
        }
    }
}
