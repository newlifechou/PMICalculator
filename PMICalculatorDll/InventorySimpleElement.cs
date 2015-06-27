using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Resources;
using System.IO;

namespace PMICalculatorDll
{
    public partial class InventorySimpleElement : Form
    {
        public string DataXMLFilePath;
        public event EventHandler<InventoryArgs> FillPath;
        public InventorySimpleElement()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);

            lvData.FullRowSelect = true;
            lvData.MultiSelect = false;
            lvData.GridLines = true;
            lvData.View = View.Details;
            lvData.Columns.Add("原子序数", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("元素名称", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("摩尔质量", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("单质密度", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("熔点", 80, HorizontalAlignment.Left);
            lvData.Columns.Add("沸点", 80, HorizontalAlignment.Left);
        }
        private void InventorySimpleElement_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (!File.Exists(DataXMLFilePath))
            {
                return;
            }

            XDocument doc = XDocument.Load(DataXMLFilePath);
            var query = from se in doc.Descendants("Substance")
                        select new
                        {
                            ElementName = se.Attribute("ElementName").Value,
                            ANumber = Convert.ToInt32(se.Attribute("ANumber").Value),
                            MolWeight = se.Element("MolWeight").Value,
                            Density = se.Element("Density").Value,
                            MeltingPoint = se.Element("MeltingPoint").Value,
                            BoilingPoint = se.Element("BoilingPoint").Value
                        };
            var list = query.ToList();
            list.Sort((a, b) => a.ANumber.CompareTo(b.ANumber));
            foreach (var item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ANumber.ToString() ;
                lvi.SubItems.Add(item.ElementName);
                lvi.SubItems.Add(item.MolWeight);
                lvi.SubItems.Add(item.Density);
                lvi.SubItems.Add(item.MeltingPoint);
                lvi.SubItems.Add(item.BoilingPoint);
                lvData.Items.Add(lvi);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count == 0)
            {
                return;
            }
            if (FillPath != null)
            {
                InventoryArgs args = new InventoryArgs();
                args.Para1 = lvData.SelectedItems[0].SubItems[1].Text;
                args.Para2 = lvData.SelectedItems[0].SubItems[2].Text;
                args.Para3 = lvData.SelectedItems[0].SubItems[3].Text;
                args.Para4 = lvData.SelectedItems[0].SubItems[4].Text;
                args.Para5 = lvData.SelectedItems[0].SubItems[5].Text;

                FillPath(this, args);
            }
            this.Close();
        }
    }
}
