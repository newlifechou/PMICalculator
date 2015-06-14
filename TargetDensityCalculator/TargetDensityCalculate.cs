using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetDensityCalculator
{
    /// <summary>
    /// 靶材密度计算类
    /// </summary>
    public class TargetDensityCalculate
    {
        //三个输出结果
        public double RealDensity { get; set; }
        public double RelativeDensity { get; set; }
        public double Volume { get; set; }

        /// <summary>
        /// 方形靶材的密度计算
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="thickness"></param>
        /// <param name="theoreticalDensity"></param>
        public void CalculateRectangleTargetTargetDensity(double weight, double width, double height, double thickness, double theoreticalDensity)
        {
            if (weight <= 0 || width <= 0 || height <= 0 || thickness <= 0 || theoreticalDensity <= 0)
            {
                throw new Exception("靶材重量，长度，宽度，厚度，理论密度必须为正数");
            }
            this.Volume = width * height * thickness / 1000;
            this.RealDensity = weight / this.Volume;
            this.RelativeDensity = this.RealDensity / theoreticalDensity;
        }
        /// <summary>
        /// 圆形靶材的密度计算
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="diameter"></param>
        /// <param name="thickness"></param>
        /// <param name="theoreticalDensity"></param>
        public void CalculateCirlcleTargetDensity(double weight, double diameter, double thickness, double theoreticalDensity)
        {
            if (weight <= 0 || diameter <= 0 || thickness <= 0 || theoreticalDensity <= 0)
            {
                throw new Exception("靶材重量，直径，厚度，理论密度必须为正数");
            }
            this.Volume = Math.PI * diameter * diameter * thickness / 4 / 1000;
            this.RealDensity = weight / this.Volume;
            this.RelativeDensity = this.RealDensity / theoreticalDensity;

        }
        /// <summary>
        /// 阿基米德法，排水法
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="w1"></param>
        /// <param name="w2"></param>
        /// <param name="theoreticalDensity"></param>
        public void CalculateArchimedeTargetDensity(double weight, double w1, double w2, double theoreticalDensity)
        {
            if (weight <= 0 || w1 <= 0 || w2 <= 0 || theoreticalDensity <= 0)
            {
                throw new Exception("靶材重量，W1，W2，理论密度必须为正数");
            }
            if (w1 <= w2)
            {
                throw new Exception("W1的数值必须大于W2");
            }

            this.Volume = w1 - w2;
            this.RealDensity = weight / this.Volume;
            this.RelativeDensity = this.RealDensity / theoreticalDensity;
        }



    }
}
