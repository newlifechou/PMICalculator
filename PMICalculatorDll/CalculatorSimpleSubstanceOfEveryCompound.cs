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
    public partial class CalculatorSimpleSubstanceOfEveryCompound : Form
    {
        public string DataXMLFilePath;
        public CalculatorSimpleSubstanceOfEveryCompound()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnInventorySimpleSubstance_Click(object sender, EventArgs e)
        {
            InventorySimpleElement ise = new InventorySimpleElement();
            ise.DataXMLFilePath = DataXMLFilePath;
            ise.FillPath += ise_FillPath;
            ise.ShowDialog();
        }

        private void ise_FillPath(object sender, InventoryArgs e)
        {
            
        }
    }
}
