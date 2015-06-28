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
    public partial class CalculatorMaterialRequirement : Form
    {
        public string DataXMLFilePathMold;
        public string DataXMLFilePathDensity;

        private List<MaterialRequirementItem> CalculateList;
        public CalculatorMaterialRequirement()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
            CalculateList = new List<MaterialRequirementItem>();
            dgvCostCalculateList.AutoGenerateColumns = false;
        }

        private void btnInventoryMold_Click(object sender, EventArgs e)
        {
            InventoryMold IM = new InventoryMold();
            IM.DataXMLFilePath = DataXMLFilePathMold;
            IM.FillIn += IM_FillIn;
            IM.ShowDialog();
        }

        private void IM_FillIn(object sender, InventoryArgs e)
        {
            txtMoldDiameter.Text = e.Para1;
        }

        private void btnInventoryDensity_Click(object sender, EventArgs e)
        {
            InventoryDensity id = new InventoryDensity();
            id.DataXMLFilePath = DataXMLFilePathDensity;
            id.FillPath += id_FillPath;
            id.ShowDialog();
        }

        private void id_FillPath(object sender, InventoryArgs e)
        {
            txtDensity.Text = e.Para2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nameType = "";
                double density, d, h1, h2, number, weight;
                if (rdoType1.Checked)
                {
                    nameType = rdoType1.Text;
                }
                if (rdoType2.Checked)
                {
                    nameType = rdoType2.Text;
                }

                CommonOperate.ConvertStringToDouble(txtDensity, out density);
                CommonOperate.ConvertStringToDouble(txtMoldDiameter, out d);
                CommonOperate.ConvertStringToDouble(txtThickness, out h1);
                if (chkThicknessMore.Checked)
                {
                    CommonOperate.ConvertStringToDouble(txtThicknessMore, out h2);
                    h1 += h2;
                }
                CommonOperate.ConvertStringToDouble(txtNumber, out number);
                weight = Math.PI * d * d * h1 / 4000 * density * number;
                MaterialRequirementItem tmp = new MaterialRequirementItem();
                tmp.NameType = nameType;
                tmp.Diameter = d;
                tmp.Thickness = h1;
                tmp.Number = number;
                tmp.Weight = weight;
                CalculateList.Add(tmp);

                BindToDgAndCalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindToDgAndCalculateTotal()
        {
            dgvCostCalculateList.DataSource = null;
            dgvCostCalculateList.DataSource = CalculateList;
            btnCalTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CalculateList.Count==0)
            {
                return;
            }
            int index = dgvCostCalculateList.CurrentRow.Index;
            CalculateList.RemoveAt(index);
            BindToDgAndCalculateTotal();
        }
        private void btnCalTotal()
        {
            double sum = 0;
            foreach (var item in CalculateList)
            {
                sum += item.Weight;
            }
            if (chkLoss.Checked)
            {
                double loss;
                CommonOperate.ConvertStringToDouble(txtLoss, out loss);
                sum += loss;
            }
            txtTotal.Text = sum.ToString("N2");
        }

        private void txtLoss_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double loss;
                CommonOperate.ConvertStringToDouble(txtLoss, out loss);
                btnCalTotal();
            }
            catch (Exception ex)
            {
                txtLoss.Text = "100";
                MessageBox.Show(ex.Message);
            }
        }

        private void chkLoss_CheckedChanged(object sender, EventArgs e)
        {
            btnCalTotal();
            txtLoss.Enabled = chkLoss.Checked;
        }

        private void chkThicknessMore_CheckedChanged(object sender, EventArgs e)
        {
            txtThicknessMore.Enabled = chkThicknessMore.Checked;
        }
    }
}
