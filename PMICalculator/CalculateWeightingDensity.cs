using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICalculator
{
    /// <summary>
    /// 计算加权密度
    /// </summary>
    public class CalculateWeightingDensity
    {
        /// <summary>
        /// 知道Wt，计算加权密度
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public double CalculateWeightingDensityFromWt(List<WeightingDensityItem> list)
        {
            double sum=0;
            foreach (var item in list)
            {
                sum += item.ItemWt;
            }
            if (sum!=100)
            {
                throw new Exception("Wt和必须为100,请重新修改");
            }
            double density=0;
            foreach (var item in list)
            {
                density += item.ItemDensity * item.ItemWt/100;
            }
            return density;
        }

        /// <summary>
        /// 知道At计算加权密度
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public double CalculateWeightingDensityFromAt(List<WeightingDensityItem> list)
        {
            double density = 0;
            double sum=0;
            foreach (var item in list)
            {
                sum += item.ItemAt;
            }
            if (sum!=100)
            {
                throw new Exception("At和必须为100");
            }
            //通过At和MolWeight计算出Wt
            double Tmp = 0;
            foreach (var item in list)
            {
                Tmp += item.ItemAt * item.ItemMolWeight;
            }
            foreach (var item in list)
            {
                item.ItemWt = item.ItemAt * item.ItemMolWeight / Tmp*100;
            }
            //通过Wt计算出density
            foreach (var item in list)
            {
                density += item.ItemDensity * item.ItemWt / 100;
            }

            return density;
        }

    }
}
