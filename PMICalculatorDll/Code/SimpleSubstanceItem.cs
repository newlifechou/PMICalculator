using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    ///化合物成分组成计算 
    /// </summary>
    public class SimpleSubstanceItem
    {
        public string ElementName { get; set; }
        public double MolWeight { get; set; }
        public double At { get; set; }
        public double Wt { get; set; }
        public double Weight { get; set; }
    }
}
