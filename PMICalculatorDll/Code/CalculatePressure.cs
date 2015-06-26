using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculatorDll
{
    /// <summary>
    /// 这个类主要用于热压机的压力换算
    /// </summary>
    public class CalculatePressure
    {
        //压力T
        public double T2 { get; set; }
        //压强MPa
        public double P1 { get; set; }

        /// <summary>
        /// 知道T1D1D2，计算T2
        /// </summary>
        public void CalculateFromT1D1D2ToT2(double d1, double d2, double t1)
        {
            if (d1 <= 0 || d2 <= 0 || t1 <= 0)
            {
                throw new Exception("所有输入必须为正值");
            }
            //计算出T2
            T2 = t1 * (d2 * d2 / d1 / d1);
            //计算出P1,MPa
            P1 = 10000 * 4 * t1 / (Math.PI * d1 * d1);
        }
        /// <summary>
        /// 知道PD，计算T
        /// </summary>
        public void CalculateFromPDToT(double p, double d)
        {
            if (p <= 0 || d <= 0)
            {
                throw new Exception("所有输入必须为正值");
            }
            T2 = Math.PI * d * d * p / (4 * 10000);

        }
        /// <summary>
        /// 知道TD，计算P
        /// </summary>
        public void CalculateFromTDToP(double t, double d)
        {
            if (t <= 0 || d <= 0)
            {
                throw new Exception("所有输入必须为正值");
            }
            //计算出P1
            P1 = 10000 * 4 * t / (Math.PI * d * d);

        }

    }
}
