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
    public partial class InventoryGraphitePaper : Form
    {
        public string DataXMLFilePath;
        public event EventHandler<InventoryArgs> FillIn;
        public InventoryGraphitePaper()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
            lvData.FullRowSelect = true;
            lvData.MultiSelect = false;
            lvData.GridLines = true;
            lvData.View = View.Details;


        }
        private void InventoryGraphitePaper_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        }


    }
}
