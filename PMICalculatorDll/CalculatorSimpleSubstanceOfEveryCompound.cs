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
    public partial class CalculatorSimpleSubstanceOfEveryCompound : Form
    {
        public string DataXMLFilePath;
        private List<SimpleSubstanceItem> CalculateList;
        private double totalWeight;
        public CalculatorSimpleSubstanceOfEveryCompound()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
            CalculateList = new List<SimpleSubstanceItem>();
            totalWeight = 0;
            dgvCalculateList.AutoGenerateColumns = false;
        }

        private void btnInventorySimpleSubstance_Click(object sender, EventArgs e)
        {
            InventorySimpleElement ise = new InventorySimpleElement();
            ise.DataXMLFilePath = DataXMLFilePath;
            ise.FillPath += ise_FillPath;
            ise.ShowDialog();
        }

        private void ise_FillPath(object sender, InventoryArgs e)
        {
            txtElementName.Text = e.Para1;
            txtMolWeight.Text = e.Para2;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CommonOperate.ConvertStringToDouble(txtWeight, out totalWeight);
                double sum, wt, weight;
                sum = wt = weight = 0;
                foreach (var item in CalculateList)
                {
                    sum += item.At;
                }
                if (sum!=100)
                {
                    throw new Exception("所有At和必须为100");
                }
                sum = 0;
                foreach (var item in CalculateList)
                {
                    item.Wt = item.MolWeight * item.At;
                    sum += item.Wt;
                }
                foreach (var item in CalculateList)
                {
                    item.Wt = item.Wt/ sum*100;
                    item.Weight = item.Wt * totalWeight/100;
                }

                dgvCalculateList.DataSource = null;
                dgvCalculateList.DataSource = CalculateList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double molWeight, At;

                CommonOperate.IsNullOrEmptyString(txtElementName);
                CommonOperate.ConvertStringToDouble(txtWeight, out totalWeight);
                CommonOperate.ConvertStringToDouble(txtMolWeight, out molWeight);
                CommonOperate.ConvertStringToDouble(txtAt, out At);
                SimpleSubstanceItem tmp = new SimpleSubstanceItem();
                tmp.ElementName = txtElementName.Text;
                tmp.MolWeight = molWeight;
                tmp.At = At;
                CalculateList.Add(tmp);

                dgvCalculateList.DataSource = null;
                dgvCalculateList.DataSource = CalculateList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CalculateList.Count==0)
            {
                return;
            }
            int index = dgvCalculateList.CurrentRow.Index;
            CalculateList.RemoveAt(index);
            dgvCalculateList.DataSource = null;
            dgvCalculateList.DataSource = CalculateList;
        }
    }
}
