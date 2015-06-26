using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 模具实体类
    /// </summary>
    public class EntityMoldItem
    {
        public int MoldId { get; set; }
        public double InnerDiameter { get; set; }
        public double Height { get; set; }
        public string MoldType { get; set; }
        public string Remark { get; set; }

    }
}
