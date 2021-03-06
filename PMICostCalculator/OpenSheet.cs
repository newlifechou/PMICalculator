﻿using System;
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
    public partial class OpenSheet : Form
    {
        public OpenSheet()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);

            //初始化
            lvFileList.Columns.Add("FileName", 200);
            lvFileList.Columns.Add("CreateTime", 200);
            lvFileList.Columns.Add("Updatetime", 200);
            lvFileList.Columns.Add("Details", 400);
        }
        public event EventHandler<CostCalculationSheetEventArgs> OpenDoc;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count == 0)
            {
                return;
            }
            string filename = lvFileList.SelectedItems[0].SubItems[3].Text;
            if (MessageBox.Show("Want to delete this file?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    MessageBox.Show("Delete Successfully");
                    LoadXMLFiles();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count == 0)
            {
                return;
            }
            if (OpenDoc != null)
            {
                CostCalculationSheetEventArgs args = new CostCalculationSheetEventArgs();
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
            List<FileInfo> filesOrigin = FileOperate.GetFiles(dirpath);
            //按照文件的创建时间排序,最新的在最前面
            List<FileInfo> files = filesOrigin.OrderByDescending(r => r.CreationTime).ToList<FileInfo>() ;

            lvFileList.BeginUpdate();
            lvFileList.Items.Clear();
            foreach (var item in files)
            {
                ListViewItem lvi = new ListViewItem();
                string filename = item.Name.Substring(0, item.Name.LastIndexOf('.'));
                lvi.Text = filename;
                lvi.SubItems.Add(item.CreationTime.ToString());
                lvi.SubItems.Add(item.LastWriteTime.ToString());
                lvi.SubItems.Add(item.FullName);
                lvFileList.Items.Add(lvi);
            }
            lvFileList.EndUpdate();
        }


        private void btnOpenWorkDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string dirpath = Path.Combine(Environment.CurrentDirectory, Properties.Settings.Default.WorkingDirectory);
                System.Diagnostics.Process.Start(dirpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
