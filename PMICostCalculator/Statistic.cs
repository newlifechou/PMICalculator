using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PMICostCalculator
{
    public partial class Statistic : Form
    {
        private CostCalculationSheet cs;
        private List<ItemCountUnit> ItemCategorysCount;
        private List<ItemCountUnit> ItemTypesCount;
        private decimal Total;

        public Statistic(CostCalculationSheet cs)
        {
            InitializeComponent();
            FormOperate.SetFormToDialog(this, false);
            //初始化
            this.cs = cs;
            ItemCategorysCount = new List<ItemCountUnit>();
            ItemTypesCount = new List<ItemCountUnit>();
            Total = 0;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            this.Text = "Statistic -" + cs.SheetName;
            CalculateData();
            FillBriefTxt();
            ShowChart();
        }
        /// <summary>
        /// 添加统计结果到Chart控件
        /// </summary>
        private void ShowChart()
        {
            DrawPieChart(chart1, ItemCategorysCount, "ItemCategorys");
            DrawPieChart(chart2, ItemTypesCount, "ItemTypes");
        }
        private void DrawPieChart(Chart chart,List<ItemCountUnit> itemlist,string chartName)
        {
            if (itemlist.Count==0)
            {
                return;
            }

            Series series = new Series(chartName);
            series.ChartType = SeriesChartType.Pie;
            series.Palette = ChartColorPalette.Fire;

            foreach (var item in itemlist)
            {
                DataPoint dp = new DataPoint();
                dp.LegendText = item.Name;
                dp.LabelToolTip = item.Name;
                dp.Label = (item.Value / Total).ToString("P");
                dp.YValues[0] = (double)item.Value;
                series.Points.Add(dp);
            }

            chart.Series.Clear();
            chart.Series.Add(series);
            chart.Name = chartName;
            chart.BackColor = Color.Gray;
            chart.Titles.Add(chartName+" Statistic");
        }
        /// <summary>
        /// 添加统计结果到文本框
        /// </summary>
        private void FillBriefTxt()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SheetName:");
            sb.AppendLine(cs.SheetName);
            sb.Append("Remark:");
            sb.AppendLine(cs.Remark);

            sb.AppendLine("========================================");

            sb.Append("Total=");
            sb.AppendLine(Total.ToString("N2"));

            sb.AppendLine("========================================");
            foreach (var item in ItemCategorysCount)
            {
                sb.Append(item.Name);
                sb.Append("=");

                sb.Append(item.Value.ToString("N2"));
                sb.Append("(");
                sb.Append((item.Value / Total).ToString("P"));
                sb.AppendLine(")");
            }

            sb.AppendLine("========================================");

            foreach (var item in ItemTypesCount)
            {
                sb.Append(item.Name);
                sb.Append("=");

                sb.Append(item.Value.ToString("N2"));
                sb.Append("(");
                sb.Append((item.Value / Total).ToString("P"));
                sb.AppendLine(")");
            }
            txtStatisticData.Text = sb.ToString();
        }

        private void CalculateData()
        {
            if (cs.CostItemList.Count == 0)
            {
                return;
            }

            foreach (var item in cs.CostItemList)
            {
                Total += item.ItemCost;
            }
            if (Total == 0)
            {
                return;
            }

            string[] itemCategorys = Enum.GetNames(typeof(CostItemCategory));

            string[] itemTypes = Enum.GetNames(typeof(CostItemType));


            //统计itemTypes数据
            foreach (var itemCategory in itemCategorys)
            {
                decimal sum = 0;
                foreach (var item in cs.CostItemList)
                {
                    if (item.ItemCategory.ToString() == itemCategory)
                    {
                        sum += item.ItemCost;
                    }
                }
                ItemCountUnit tmp = new ItemCountUnit();
                tmp.Name = itemCategory;
                tmp.Value = sum;
                ItemCategorysCount.Add(tmp);
            }
            //统计itemStyles数据
            foreach (var itemType in itemTypes)
            {
                decimal sum = 0;
                foreach (var item in cs.CostItemList)
                {
                    if (item.ItemType.ToString() == itemType)
                    {
                        sum += item.ItemCost;
                    }
                }
                ItemCountUnit tmp = new ItemCountUnit();
                tmp.Name = itemType;
                tmp.Value = sum;
                ItemTypesCount.Add(tmp);
            }
        }

    }
}
