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
using System.IO;

namespace PMICalculatorDll
{
    public partial class InventoryMold : Form
    {
        /// <summary>
        /// XML数据文件的路径
        /// </summary>
        public string DataXMLFilePath;
        /// <summary>
        /// 填写事件
        /// </summary>
        public event EventHandler<InventoryArgs> FillIn;
        public InventoryMold()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
            lvData.FullRowSelect = true;
            lvData.MultiSelect = false;
            lvData.GridLines = true;
            lvData.View = View.Details;
            lvData.Columns.Add("模具内径(mm)", 120, HorizontalAlignment.Right);
            lvData.Columns.Add("模具类型", 80, HorizontalAlignment.Left);
        }

        private void InventoryMold_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DataXMLFilePath))
            {
                return;
            }

            XDocument doc = XDocument.Load(DataXMLFilePath);
            var query = from m in doc.Descendants("Mold")
                        select new
                        {
                            MoldDiameter = m.Element("Diameter").Value,
                            MoldType = m.Element("Type").Value
                        };
            foreach (var item in query)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.MoldDiameter;
                lvi.SubItems.Add(item.MoldType);
                lvData.Items.Add(lvi);
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count != 0)
            {
                if (FillIn != null)
                {
                    InventoryArgs args = new InventoryArgs();
                    args.Para1 = lvData.SelectedItems[0].Text;
                    args.Para2 = lvData.SelectedItems[0].SubItems[0].Text;
                    FillIn(this, args);
                }
                this.Close();
            }
        }

    }
}
