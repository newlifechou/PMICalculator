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
    public partial class AddCostCalculateItem : Form
    {
        public AddCostCalculateItem()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
            LoadCbo();
        }
        public event EventHandler<NewCostCalcualteItemEventArgs> AddCostCalculateItemEvent;

        private void LoadCbo()
        {
            string[] itemTypes = Enum.GetNames(typeof(CostCalculateType));
            cboItemType.DataSource = null;
            cboItemType.DataSource = itemTypes;
            string[] itemStyles = Enum.GetNames(typeof(CostCalculateStyle));
            cboItemStyle.DataSource = null;
            cboItemStyle.DataSource = itemStyles;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                return;
            }

            decimal tmpValue;
            if (!decimal.TryParse(txtItemCost.Text, out tmpValue))
            {
                MessageBox.Show("ItemCost must be number");
                return;
            }
            if (AddCostCalculateItemEvent != null)
            {
                NewCostCalcualteItemEventArgs args = new NewCostCalcualteItemEventArgs();
               
                args.CostItem.ItemName = txtItemName.Text;
                args.CostItem.ItemType = (CostCalculateType)Enum.Parse(typeof(CostCalculateType), cboItemType.SelectedItem.ToString(), false);
                args.CostItem.ItemStyle = (CostCalculateStyle)Enum.Parse(typeof(CostCalculateStyle), cboItemStyle.SelectedItem.ToString(), false);
                args.CostItem.ItemCost = tmpValue;
                args.CostItem.ItemRemark = txtItemRemark.Text;

                AddCostCalculateItemEvent(this, args);
            }
            if (!chkKeepShow.Checked)
            {
                this.Close();
            }
        }
    }
}
