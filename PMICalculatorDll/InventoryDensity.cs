using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace PMICalculatorDll
{
    public partial class InventoryDensity : Form
    {
        public string DataXMLFilePath;
        public event EventHandler<InventoryArgs> FillPath;
        public InventoryDensity()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
            lvData.FullRowSelect = true;
            lvData.MultiSelect = false;
            lvData.GridLines = true;
            lvData.View = View.Details;

            lvData.Columns.Add("物质名称", 200, HorizontalAlignment.Left);
            lvData.Columns.Add("密度数据", 80, HorizontalAlignment.Left);
        }
        private void InventoryDensity_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(DataXMLFilePath))
            {
                XDocument doc = XDocument.Load(DataXMLFilePath);
                var query = from d in doc.Descendants("Compound")
                            orderby d.Value
                            select new
                            {
                                Name=d.Element("Name").Value,
                                Density=d.Element("Density").Value
                            };
                foreach (var item in query)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.Name;
                    lvi.SubItems.Add(item.Density);
                    lvData.Items.Add(lvi);
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count==0)
            {
                return;
            }
            if (FillPath!=null)
            {
                InventoryArgs args = new InventoryArgs();
                args.Para1 = lvData.SelectedItems[0].Text;
                args.Para2 = lvData.SelectedItems[0].SubItems[0].Text;

                FillPath(this, args);
            }
            this.Close();
        }
    }
}
