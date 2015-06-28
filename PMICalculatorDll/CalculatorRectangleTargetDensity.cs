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
    public partial class CalculatorRectangleTargetDensity : Form
    {
        public string DataXMLFilePath;
        public CalculatorRectangleTargetDensity()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, width, height, h1, h2, h3, h4, h, theoreticalDensity;
                CommonOperate.ConvertStringToDouble(txtWeight, out weight);
                CommonOperate.ConvertStringToDouble(txtWidth, out width);
                CommonOperate.ConvertStringToDouble(txtHeight, out height);
                CommonOperate.ConvertStringToDouble(txtThickness1, out h1);
                CommonOperate.ConvertStringToDouble(txtThickness2, out h2);
                CommonOperate.ConvertStringToDouble(txtThickness3, out h3);
                CommonOperate.ConvertStringToDouble(txtThickness4, out h4);
                CommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out theoreticalDensity);
                try
                {
                    h=(h1 + h2 + h3 + h4) / 4;
                    this.txtThickness.Text = h.ToString("N2");

                    CalculateTargetDensity tdc = new CalculateTargetDensity();
                    tdc.CalculateRectangleTargetTargetDensity(weight, width, height, h, theoreticalDensity);
                    txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                    txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
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
