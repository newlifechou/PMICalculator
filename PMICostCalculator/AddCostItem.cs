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
                txtItemCost.Clear();
                txtItemRemark.Clear();
            }
            if (!chkKeepShow.Checked)
            {
                this.Close();
            }
        }
        /// <summary>
        /// 弹出对应的成本计算器
        /// 需要简化和灵活处理的地方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculator_Click(object sender, EventArgs e)
        {

            switch (cboItemCategory.SelectedItem.ToString())
            {
                //如果CostItemCategory有变化，则这里必须跟着变化
                case "PowderProcessCost":
                    CostPowderProcess fpowder = new CostPowderProcess();
                    fpowder.FillIn += Common_FillIn;
                    fpowder.ShowDialog();
                    break;
                case "VHPCost":
                    CostVHPProcess fvhp = new CostVHPProcess();
                    fvhp.FillIn += Common_FillIn;
                    fvhp.ShowDialog();
                    break;
                case "MachiningCost":
                    CostMachiningProcess fm = new CostMachiningProcess();
                    fm.FillIn += Common_FillIn;
                    fm.ShowDialog();
                    break;
                case "PackageCost":
                    CostPackageProcess fp = new CostPackageProcess();
                    fp.FillIn += Common_FillIn;
                    fp.ShowDialog();
                    break;
                case "BondingCost":
                    CostBondingProcess fbp = new CostBondingProcess();
                    fbp.FillIn += Common_FillIn;
                    fbp.ShowDialog();
                    break;
                case "DeliveryCost":
                    CostDeliveryProcess fdp = new CostDeliveryProcess();
                    fdp.FillIn += Common_FillIn;
                    fdp.ShowDialog();
                    break;
                default:
                    MessageBox.Show("There is No Specific Calculator For this Category");
                    break;
            }
        }
        /// <summary>
        /// 通用的事件响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Common_FillIn(object sender, CostCalculatorArgs e)
        {
            txtItemCost.Text = e.CostValue.ToString("N2");
            txtItemRemark.Text = e.Remark;
        }
    }
}
