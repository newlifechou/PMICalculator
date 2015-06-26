using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 密度库项类
    /// </summary>
    public class EntityDensityItem
    {
        public int ID { get; set; }
        public string SubstanceName { get; set; }
        public double Density { get; set; }
        public string Remark { get; set; }

    }
}
