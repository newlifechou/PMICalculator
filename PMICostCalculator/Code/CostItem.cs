using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PMICostCalculator
{
    /// <summary>
    /// 成本小项类
    /// 不要轻易更改这个类的成员名称和数量，否则对应的已经生成的xml文件会存在兼容性问题
    /// </summary>
    [Serializable]
    public class CostItem : IComparable<CostItem>
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 计算项的类别
        /// </summary>
        public CostItemType ItemType { get; set; }

        /// <summary>
        /// 试验还是产品
        /// </summary>
        public CostItemStyle ItemStyle { get; set; }

        /// <summary>
        /// 项目成本花费
        /// </summary>
        public decimal ItemCost { get; set; }

        /// <summary>
        /// 项目备注信息
        /// </summary>
        public string ItemRemark { get; set; }

        public int CompareTo(CostItem other)
        {
            if (this.ItemType.CompareTo(other.ItemType) != 0)
            {
                return this.ItemType.CompareTo(other.ItemType);
            }
            else
            {
                return this.ItemStyle.CompareTo(other.ItemStyle);
            }
        }
    }
}
