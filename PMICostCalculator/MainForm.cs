﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    public partial class MainForm : Form
    {
        private CostCalculateSheet CurrentCostCalculateSheet;
        private bool IsSaved;

        public MainForm()
        {
            InitializeComponent();
            //初始化
            IsSaved = true;
        }

        /// <summary>
        /// 切换界面语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageSwitch(object sender, EventArgs e)
        {
            ToolStripMenuItem CurrentItem = sender as ToolStripMenuItem;

            foreach (var item in languageToolStripMenuItem.DropDownItems)
            {
                ToolStripMenuItem TmpItem = item as ToolStripMenuItem;
                if (TmpItem.Name == CurrentItem.Name)
                {
                    TmpItem.Checked = true;
                }
                else
                {
                    TmpItem.Checked = false;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCostCalcuate f = new NewCostCalcuate();
            f.New += f_New;
            f.ShowDialog();
        }

        private void f_New(object sender, NewCalcualteEventArgs e)
        {
            CurrentCostCalculateSheet = new CostCalculateSheet(e.CostCalculateName);
            CreateTestData();
            CurrentCostCalculateSheet.CostCalculateSheetList.Sort();
            txtCostCaculateName.Text = CurrentCostCalculateSheet.SheetName;
            dgvCostCalculateList.DataSource = null;
            dgvCostCalculateList.DataSource = CurrentCostCalculateSheet.CostCalculateSheetList;
            IsSaved = false;
        }

        private void CreateTestData()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                CostCalculateItem cci = new CostCalculateItem();
                cci.ItemName = "1506" + r.Next(10, 99) + "_SJ";
                switch (r.Next(10, 99) % 5)
                {
                    case 0:
                        cci.ItemType = CostCalculateType.MaterialsCost;
                        cci.ItemStyle = CostCalculateStyle.Product;
                        break;
                    case 1:
                        cci.ItemType = CostCalculateType.PowderProcessCost;
                        cci.ItemStyle = CostCalculateStyle.Product;
                        break;
                    case 2:
                        cci.ItemType = CostCalculateType.VHPCost;
                        cci.ItemStyle = CostCalculateStyle.Experiement;
                        break;
                    case 3:
                        cci.ItemType = CostCalculateType.MachineCost;
                        cci.ItemStyle = CostCalculateStyle.Product;
                        break;
                    case 4:
                        cci.ItemType = CostCalculateType.PacageCost;
                        cci.ItemStyle = CostCalculateStyle.Experiement;
                        break;
                    default:
                        cci.ItemType = CostCalculateType.BondingCost;
                        cci.ItemStyle = CostCalculateStyle.Experiement;
                        break;
                }
                cci.ItemCost = r.Next(1000, 9999);
                cci.ItemRemark = "三杰提供原料" + r.Next(10, 99);
                CurrentCostCalculateSheet.CostCalculateSheetList.Add(cci);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCostCalcuate f = new OpenCostCalcuate();
            f.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //如果还没有保存当前计算表
            if (!IsSaved)
            {
                MessageBox.Show("尚未保存当前计算表，是否保存?");
                //TODO:这里添加保存计算表的代码
            }
        }



    }
}
