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
    public partial class CalculatorCircleTargetDensity : Form
    {
        public string DataXMLFilePathDensity;
        public string DataXMLFilePathGraphitePaper;
        public CalculatorCircleTargetDensity()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight, diameter, h1, h2, h3, h4, h,paperWeight, paperThickness, theoreticalDensity;
                CommonOperate.ConvertStringToDouble(txtWeight, out weight);
                CommonOperate.ConvertStringToDouble(txtDiameter, out diameter);
                CommonOperate.ConvertStringToDouble(txtThickness1, out h1);
                CommonOperate.ConvertStringToDouble(txtThickness2, out h2);
                CommonOperate.ConvertStringToDouble(txtThickness3, out h3);
                CommonOperate.ConvertStringToDouble(txtThickness4, out h4);
                CommonOperate.ConvertStringToDouble(txtTheoreticalDensity, out theoreticalDensity);
                h= (h1 + h2 + h3 + h4) / 4;
                this.txtThickness.Text = h.ToString("N2");

                //如果需要减去石墨纸的重量和厚度
                if (chkIncludeCarbonPaper.Checked == true)
                {
                    CommonOperate.ConvertStringToDouble(txtPaperThickness, out paperThickness);
                    CommonOperate.ConvertStringToDouble(txtPapterWeight, out paperWeight);

                    h = h - paperThickness;
                    this.txtMovePaperThickness.Text = h.ToString("N2");
                    weight = weight - paperWeight;
                    this.txtMovePaperWeight.Text = weight.ToString("N2");
                }

                CalculateTargetDensity tdc = new CalculateTargetDensity();
                tdc.CalculateCirlcleTargetDensity(weight, diameter, h, theoreticalDensity);
                txtRealDensity.Text = tdc.RealDensity.ToString("N3");
                txtRelativeDensity.Text = (tdc.RelativeDensity * 100).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkIncludeCarbonPaper_CheckedChanged(object sender, EventArgs e)
        {
            panelPaper.Enabled= chkIncludeCarbonPaper.Checked;
            panelMovePaper.Visible = chkIncludeCarbonPaper.Checked;
        }

        private void btnInventoryGrahpitePaper_Click(object sender, EventArgs e)
        {
            InventoryGraphitePaper igp = new InventoryGraphitePaper();
            igp.DataXMLFilePath = DataXMLFilePathGraphitePaper;
            igp.FillIn += igp_FillIn;
            igp.ShowDialog();
        }

        private void igp_FillIn(object sender, InventoryArgs e)
        {
            txtPapterWeight.Text = e.Para2;
            txtPaperThickness.Text = e.Para3;
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
            txtTheoreticalDensity.Text = e.Para2;
        }
    }
}
