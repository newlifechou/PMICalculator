using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeightedDensityCalculator.Models;


namespace WeightedDensityCalculator.Service
{
    public class WeightedDensityCalculationService
    {

        public WeightedDensityCalculationService()
        {
            SubstanceGroup = new List<CalculationSubstance>();
        }


        public List<CalculationSubstance> SubstanceGroup { get; set; }

        /// <summary>
        /// 得到该组元素的加权密度
        /// </summary>
        /// <returns></returns>
        public double GetWeightedDensity()
        {
            double weightedDensity = 0;
            double sum = (from element in SubstanceGroup
                          select element.At * element.MolWeight).Sum();

            foreach (var element in SubstanceGroup)
            {
                element.Wt = element.At * element.MolWeight / sum;
                weightedDensity += element.Wt * element.Density;
            }
            return weightedDensity;
        }


    }
}
