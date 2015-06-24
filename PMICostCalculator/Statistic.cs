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
    public partial class Statistic : Form
    {
        private CostCalculationSheet cs;
        public Statistic(CostCalculationSheet cs)
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
            this.cs = cs;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            if (cs.CostItemList.Count==0)
            {
                return;
            }


            StringBuilder sb = new StringBuilder();
            sb.Append("SheetName:");
            sb.AppendLine(cs.SheetName);
            sb.Append("Remark:");
            sb.AppendLine(cs.Remark);

            sb.AppendLine("========================================");
            decimal total = 0;
            foreach (var item in cs.CostItemList)
            {
                total += item.ItemCost;
            }
            if (total==0)
            {
                return;
            }
            sb.Append("Total:");
            sb.AppendLine(total.ToString("N2"));

            sb.AppendLine("========================================");

            string[] itemTypes = Enum.GetNames(typeof(CostItemType));
            string[] itemStyles = Enum.GetNames(typeof(CostItemStyle));

            foreach (var itemType in itemTypes)
            {
                sb.Append(itemType);
                sb.Append("=");

                decimal sum = 0;
                foreach (var item in cs.CostItemList)
                {
                    if (item.ItemType.ToString() == itemType)
                    {
                        sum += item.ItemCost;
                    }
                }
                sb.Append(sum.ToString("N2"));
                sb.Append("(");
                sb.Append((sum / total).ToString("P"));
                sb.AppendLine(")");
            }

            sb.AppendLine("========================================");
            foreach (var itemStyle in itemStyles)
            {
                sb.Append(itemStyle);
                sb.Append("=");

                decimal sum = 0;
                foreach (var item in cs.CostItemList)
                {
                    if (item.ItemStyle.ToString() == itemStyle)
                    {
                        sum += item.ItemCost;
                    }
                }
                sb.Append(sum.ToString("N2"));
                sb.Append("(");
                sb.Append((sum / total).ToString("P"));
                sb.AppendLine(")");
            }

            txtStatisticData.Text = sb.ToString();
        }

    }
}
