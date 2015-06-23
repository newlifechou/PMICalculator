using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    /// <summary>
    /// 成本计算大类
    /// 这个类对应每一个成本表，或者对应每一个保存的XML文件
    /// </summary>
    class CostCalculateItem
    {
        //成本计算类的名称
        public string CostCalculateName { get; set; }

        //所有计算的大项，每个大项包含很多小项
        public List<CostItem> MaterialsCosts {get;set;}
        public List<CostItem> PowderProcessCosts { get; set; }
        public List<CostItem> VHPCosts { get; set; }
        public List<CostItem> MachiningCosts{ get; set; }
        public List<CostItem> TestingAndPacagingCost { get; set; }



    }
}
