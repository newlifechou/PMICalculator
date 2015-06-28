using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMICalculatorDll
{
    public partial class CalculatorExcelSheets : Form
    {
        public CalculatorExcelSheets()
        {
            InitializeComponent();
            CommonOperate.SetFormToFixedSingleDialog(this);
        }
        public List<FileInfo> ExcelSheets;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lstExcelSheets.SelectedItems.Count==0)
            {
                return;
            }
            try
            {
                System.Diagnostics.Process.Start(lstExcelSheets.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            finally
            {
                this.Close();
            }
        }

        private void CalculatorExcelSheets_Load(object sender, EventArgs e)
        {
            //判断ExcelSheet列表不为空
            if (ExcelSheets!=null)
            {
                lstExcelSheets.DisplayMember = "Name";
                lstExcelSheets.ValueMember = "FullName";
                lstExcelSheets.DataSource = ExcelSheets;
            }
        }
    }
}
