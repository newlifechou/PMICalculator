using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// Inventory通用参数类
    /// </summary>
    public class InventoryArgs : EventArgs
    {
        public string Para1{ get; set; }
        public string Para2{ get; set; }
        public string Para3 { get; set; }
        public string Para4 { get; set; }
        public string Para5 { get; set; }
    }
}
