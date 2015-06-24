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
        public event EventHandler<NewCostItemEventArgs> AddCostCalculateItemEvent;

        private void LoadCbo()
        {
            string[] itemTypes = Enum.GetNames(typeof(CostItemType));
            cboItemType.DataSource = null;
            cboItemType.DataSource = itemTypes;
            string[] itemStyles = Enum.GetNames(typeof(CostItemStyle));
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
                NewCostItemEventArgs args = new NewCostItemEventArgs();
               
                args.CostItem.ItemName = txtItemName.Text;
                args.CostItem.ItemType = (CostItemType)Enum.Parse(typeof(CostItemType), cboItemType.SelectedItem.ToString(), false);
                args.CostItem.ItemStyle = (CostItemStyle)Enum.Parse(typeof(CostItemStyle), cboItemStyle.SelectedItem.ToString(), false);
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
