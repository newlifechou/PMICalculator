using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PMICostCalculator
{
    /// <summary>
    /// 成本小项类
    /// </summary>
    [Serializable]
    public class CostCalculateItem:IComparable<CostCalculateItem>
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 计算项的类别
        /// </summary>
        public CostCalculateType ItemType { get; set; }

        /// <summary>
        /// 试验还是产品
        /// </summary>
        public CostCalculateStyle ItemStyle { get; set; }

        /// <summary>
        /// 项目成本花费
        /// </summary>
        public decimal ItemCost { get; set; }

        /// <summary>
        /// 项目备注信息
        /// </summary>
        public string ItemRemark { get; set; }

        public int CompareTo(CostCalculateItem other)
        {
            return this.ItemType.CompareTo(other.ItemType);
        }
    }
}
