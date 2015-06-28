using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 这个类用于原材料需求计算
    /// </summary>
    public class MaterialRequirementItem
    {
        public string NameType { get; set; }
        public double Diameter { get; set; }
        public double Thickness { get; set; }
        public double Number { get; set; }
        public double SingleWeight { get; set; }
        public double Weight { get; set; }
    }
}
