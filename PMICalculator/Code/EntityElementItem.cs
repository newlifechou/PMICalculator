using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 元素项类
    /// </summary>
    public class EntityElementItem
    {
        public int ID { get; set; }
        public string ElementName { get; set; }
        public double MoldWeight { get; set; }
        public double Density { get; set; }
        public double MeltingPoint { get; set; }
        public double BoilingPoint { get; set; }
        
    
    }
}
