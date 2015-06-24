using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    public class CostCalculationSheetEventArgs : EventArgs
    {
        public string CalcualteSheetFileName { get; set; }
        public string Remark { get; set; }
    }
}
