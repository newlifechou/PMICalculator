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

            lvData.Columns.Add("直径mm)", 120, HorizontalAlignment.Right);
            lvData.Columns.Add("重量g)", 120, HorizontalAlignment.Right);
            lvData.Columns.Add("厚度mm)", 120, HorizontalAlignment.Right);
        }
        private void InventoryGraphitePaper_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(DataXMLFilePath))
            {
                XDocument doc = XDocument.Load(DataXMLFilePath);
                var query = from gp in doc.Descendants("Paper")
                            orderby Convert.ToDouble(gp.Element("Diameter").Value)
                            select new
                            {
                                Diameter =gp.Element("Diameter").Value,
                                Weight=gp.Element("Weight").Value,
                                Thickness=gp.Element("Thickness").Value
                            };
                foreach (var item in query)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.Diameter;
                    lvi.SubItems.Add(item.Weight);
                    lvi.SubItems.Add(item.Thickness);
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
            if (FillIn!=null)
            {
                InventoryArgs args = new InventoryArgs();
                args.Para1 = lvData.SelectedItems[0].SubItems[0].Text;
                args.Para2 = lvData.SelectedItems[0].SubItems[1].Text;
                args.Para3 = lvData.SelectedItems[0].SubItems[2].Text;
                FillIn(this, args);
            }
            this.Close();
        }
    }
}
