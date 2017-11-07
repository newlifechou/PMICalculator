using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCompositionSimulator
{
   public class SingleElement
    {
        public SingleElement()
        {
            Element = "";
            Ratio = 0;
            Offset = 0.5;
        }
        public string Element { get; set; }
        public double Ratio { get; set; }
        public double Offset { get; set; }

    }
}
