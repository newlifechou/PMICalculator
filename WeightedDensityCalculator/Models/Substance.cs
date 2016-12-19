using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedDensityCalculator.Models
{
    public class Substance
    {
        public string ElementName { get; set; }
        public int ANumber { get; set; }
        public double MolWeight { get; set; }
        public double Density { get; set; }
        public string MeltingPoint { get; set; }
        public string BoilingPoint { get; set; }
        public string Reamark { get; set; }
    }
}
