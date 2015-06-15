﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculator
{
    public partial class CalculatorWeightingDensityByAt : Form
    {
        public CalculatorWeightingDensityByAt()
        {
            InitializeComponent();
            FormCommonOperate.SetFormToFixedSingleDialog(this);
            dgv.AutoGenerateColumns = false;
        }
        private List<WeightingDensityItem> list = new List<WeightingDensityItem>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WeightingDensityItem wdi = new WeightingDensityItem();
            try
            {
                double itemAt,itemMolWeight, itemDensity;
                wdi.ItemName = txtItemName.Text;
                if (wdi.ItemName == "")
                {
                    throw new Exception("名称不能为空");
                }
                FormCommonOperate.ConvertStringToDouble(txtItemAt, out itemAt);
                FormCommonOperate.ConvertStringToDouble(txtItemDensity, out itemDensity);
                FormCommonOperate.ConvertStringToDouble(txtItemMolWeight, out itemMolWeight);
                wdi.ItemAt = itemAt;
                wdi.ItemMolWeight = itemMolWeight;
                wdi.ItemDensity = itemDensity;
                list.Add(wdi);
                dgv.DataSource = null;
                dgv.DataSource = list;
                txtItemName.Text = "";
                txtItemDensity.Text = "";
                txtItemAt.Text = "";
                txtItemMolWeight.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("暂时没有选中行");
                return;
            }
            int index = dgv.SelectedRows[0].Index;
            list.RemoveAt(index);
            dgv.DataSource = null;
            dgv.DataSource = list;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateWeightingDensity cwd = new CalculateWeightingDensity();
                double density = cwd.CalculateWeightingDensityFromAt(list);
                txtWeightingDensity.Text = density.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
