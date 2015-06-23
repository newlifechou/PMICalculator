using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    /// <summary>
    /// 成本小项类
    /// </summary>
    class CostItem
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 项目成本
        /// </summary>
        public decimal ItemCost { get; set; }
        /// <summary>
        /// 项目备注
        /// </summary>
        public string ItemRemark { get; set; }



    }
}
