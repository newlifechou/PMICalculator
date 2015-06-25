using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    public class CostCalculatorArgs:EventArgs
    {
        public decimal CostValue { get; set; }
        public string Remark { get; set; }
    }
}
