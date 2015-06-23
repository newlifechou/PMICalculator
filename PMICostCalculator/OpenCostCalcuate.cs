using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PMICostCalculator
{
    public partial class OpenCostCalcuate : Form
    {
        public OpenCostCalcuate()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);

            //初始化
            lvFileList.Columns.Add("文件名",200);
            lvFileList.Columns.Add("创建时间",200);
            lvFileList.Columns.Add("修改时间",200);
            lvFileList.Columns.Add("详细地址",400);
        }
        public event EventHandler<CalcualteSheetEventArgs> OpenDoc;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count==0)
            {
                return;
            }
            string filename = lvFileList.SelectedItems[0].SubItems[3].Text;
            //TODO:确认删除判断
            if (File.Exists(filename))
            {
                File.Delete(filename);
                MessageBox.Show("删除成功");
                LoadXMLFiles();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count == 0)
            {
                return;
            }
            if (OpenDoc!=null)
            {
                CalcualteSheetEventArgs args = new CalcualteSheetEventArgs();
                args.CalcualteSheetFileName = lvFileList.SelectedItems[0].SubItems[3].Text;
                OpenDoc(this, args);
            }
            this.Close();
        }

        private void OpenCostCalcuate_Load(object sender, EventArgs e)
        {
            LoadXMLFiles();
        }

        private void LoadXMLFiles()
        {
            string dirpath = Properties.Settings.Default.WorkingDirectory;
            List<FileInfo> files = FileOperate.GetFiles(dirpath);
            lvFileList.BeginUpdate();
            lvFileList.Items.Clear();
            foreach (var item in files)
            {
                ListViewItem lvi = new ListViewItem();
                string filename = item.Name.Substring(0, item.Name.LastIndexOf('.'));
                lvi.Text =filename;
                lvi.SubItems.Add(item.CreationTime.ToString());
                lvi.SubItems.Add(item.LastWriteTime.ToString());
                lvi.SubItems.Add(item.FullName);
                lvFileList.Items.Add(lvi);
            }
            lvFileList.EndUpdate();
        }
    }
}
