using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    public class NewCostCalcualteItemEventArgs:EventArgs
    {
        public CostCalculateItem CostItem { get; set; }
        /// <summary>
        /// 初始化引用变量
        /// </summary>
        public NewCostCalcualteItemEventArgs()
        {
            CostItem = new CostCalculateItem();
        }
    }
}
