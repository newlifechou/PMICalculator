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
    public partial class CalculatorArchimedesDensity : Form
    {
        public string DataXMLFilePath;
        public CalculatorArchimedesDensity()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, w1, w2, thereticaldensity;
                //当所有的textbox都转换成功的时候，才可以进行计算
                CommonOperate.ConvertStringToDouble(txtWeight, out weight);
                CommonOperate.ConvertStringToDouble(txtW1, out w1);
                CommonOperate.ConvertStringToDouble(txtW2, out w2);
                CommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out thereticaldensity);

                CalculateTargetDensity tdc = new CalculateTargetDensity();
                tdc.CalculateArchimedeTargetDensity(weight, w1, w2, thereticaldensity);
                txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInventoryDensity_Click(object sender, EventArgs e)
        {
            InventoryDensity id = new InventoryDensity();
            id.DataXMLFilePath = DataXMLFilePath;
            id.FillPath += id_FillPath;
            id.ShowDialog();
        }

        private void id_FillPath(object sender, InventoryArgs e)
        {
            txtTheoreticalDensity.Text = e.Para2;
        }
    }
}
