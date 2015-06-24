using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    public class NewCostItemEventArgs:EventArgs
    {
        public CostItem CostItem { get; set; }
        /// <summary>
        /// 初始化引用变量
        /// </summary>
        public NewCostItemEventArgs()
        {
            CostItem = new CostItem();
        }
    }
}
