using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    public class CostCalcualtionSheetEventArgs : EventArgs
    {
        public string CalcualteSheetFileName { get; set; }
    }
}
