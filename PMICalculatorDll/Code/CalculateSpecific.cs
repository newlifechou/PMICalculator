using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    public class CalculateSpecific
    {
        public double CalculateFillMaterials(double density,double d,double h,double number)
        {
            double weight = 0;
            weight = Math.PI * d * d * h / 4000 * density * number;
            return weight;
        }
    }
}
