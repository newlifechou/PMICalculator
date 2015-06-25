using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICostCalculator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
            LoadSettings();

        }

        private void LoadSettings()
        {
            try
            {
                txtUnitCostPowderProcess.Text = Properties.Settings.Default.UnitCostPowderProcess.ToString("N2");
                txtUnitCostVHP.Text = Properties.Settings.Default.UnitCostVHP.ToString("N2");
                txtUnitCostMachining.Text = Properties.Settings.Default.UnitCostMachine.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal UnitCostPowderProcess, UnitCostVHP, UnitCostMachining;
            UnitCostMachining = UnitCostPowderProcess = UnitCostVHP = 0;
            if (decimal.TryParse(txtUnitCostPowderProcess.Text,out UnitCostPowderProcess)&&
                decimal.TryParse(txtUnitCostVHP.Text,out UnitCostVHP)&&
                decimal.TryParse(txtUnitCostMachining.Text,out UnitCostMachining))
            {
                Properties.Settings.Default.UnitCostPowderProcess = UnitCostPowderProcess;
                Properties.Settings.Default.UnitCostVHP = UnitCostVHP;
                Properties.Settings.Default.UnitCostMachine = UnitCostMachining;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("All The Setting Values must be numbers");
            }

        }
    }
}
