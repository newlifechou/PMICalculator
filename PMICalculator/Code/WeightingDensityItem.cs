using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 加权密度用到的item
    /// </summary>
    public class WeightingDensityItem
    {
        public string ItemName { get; set; }
        public double ItemDensity { get; set; }
        public double ItemMolWeight { get; set; }
        public double ItemWt { get; set; }
        public double ItemAt { get; set; }
    }
}
