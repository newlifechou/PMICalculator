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
    public partial class CalculatorWeightingDensityByWt : Form
    {
        public string DataXMLFilePath;
        public CalculatorWeightingDensityByWt()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
            dgv.AutoGenerateColumns = false;
        }
        private List<WeightingDensityItem> list = new List<WeightingDensityItem>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WeightingDensityItem wdi = new WeightingDensityItem();
            try
            {
                double itemWt, itemDensity;
                wdi.ItemName = txtItemName.Text;
                if (wdi.ItemName == "")
                {
                    throw new Exception("名称不能为空");
                }
                CommonOperate.ConvertStringToDouble(txtItemWt, out itemWt);
                CommonOperate.ConvertStringToDouble(txtItemDensity, out itemDensity);
                wdi.ItemWt = itemWt;
                wdi.ItemDensity = itemDensity;
                list.Add(wdi);
                dgv.DataSource = null;
                dgv.DataSource = list;
                txtItemName.Text = "";
                txtItemDensity.Text = "";
                txtItemWt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateWeightingDensity cwd = new CalculateWeightingDensity();
                double density=cwd.CalculateWeightingDensityFromWt(list);
                txtWeightingDensity.Text = density.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count==0)
            {
                MessageBox.Show("暂时没有选中行");
                return;
            }
            int index = dgv.SelectedRows[0].Index;
            list.RemoveAt(index);
            dgv.DataSource = null;
            dgv.DataSource = list;
        }

        private void btnInventorySimpleSubstance_Click(object sender, EventArgs e)
        {
            InventorySimpleElement ise=new InventorySimpleElement();
            ise.DataXMLFilePath = DataXMLFilePath;
            ise.FillPath += ise_FillPath;
            ise.ShowDialog();
        }

        private void ise_FillPath(object sender, InventoryArgs e)
        {
            txtItemName.Text = e.Para1;
            txtItemDensity.Text=e.Para3;
        }
    }
}
