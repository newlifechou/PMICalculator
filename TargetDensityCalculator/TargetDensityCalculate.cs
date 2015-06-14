using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetDensityCalculator
{
    public class TargetDensityCalculate
    {
        public double RealDensity { get; set; }
        public double RelativeDensity { get; set; }

        public void CalculateCircleTargetTargetDensity()
        {

        }
        public void CalculateRectangleTargetDensity()
        {

        }
        public void CalculateArchimedeTargetDensity(double weight, double w1, double w2, double theoreticalDensity)
        {
            if (weight <= 0 || w1 <= 0 || w2 <= 0 || theoreticalDensity <= 0)
            {
                throw new Exception("靶材重量，W1，W2，理论密度必须为正数");
            }
            if (w1<=w2)
            {
                throw new Exception("W1的数值必须大于W2");
            }
            this.RealDensity = weight / (w1 - w2);
            this.RelativeDensity = this.RealDensity / theoreticalDensity;
        }
    }
}
