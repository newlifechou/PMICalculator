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
    public partial class AddCostItem : Form
    {
        public AddCostItem()
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
            LoadCbo();
        }
        public event EventHandler<NewCostItemEventArgs> AddCostCalculateItemEvent;

        private void LoadCbo()
        {
            string[] itemCategorys = Enum.GetNames(typeof(CostItemCategory));
            cboItemCategory.DataSource = null;
            cboItemCategory.DataSource = itemCategorys;
            string[] itemTypes = Enum.GetNames(typeof(CostItemType));
            cboItemType.DataSource = null;
            cboItemType.DataSource = itemTypes;
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
                args.CostItem.ItemCategory = (CostItemCategory)Enum.Parse(typeof(CostItemCategory), cboItemCategory.SelectedItem.ToString(), false);
                args.CostItem.ItemType = (CostItemType)Enum.Parse(typeof(CostItemType), cboItemType.SelectedItem.ToString(), false);
                args.CostItem.ItemCost = tmpValue;
                args.CostItem.ItemRemark = txtItemRemark.Text;

                AddCostCalculateItemEvent(this, args);

                txtItemName.Clear();
            }
            if (!chkKeepShow.Checked)
            {
                this.Close();
            }
        }
    }
}
