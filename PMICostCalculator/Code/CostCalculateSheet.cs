using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PMICostCalculator
{
    /// <summary>
    /// 成本计算大类
    /// 这个类对应每一个成本表，或者对应每一个保存的XML文件
    /// </summary>
    [Serializable]
    public class CostCalculateSheet
    {
        //成本计算类的名称
        public string SheetName { get; set; }

        //所有成本项目
        public List<CostCalculateItem> CostCalculateSheetList{get;set;}

        public CostCalculateSheet()
        {
            this.CostCalculateSheetList = new List<CostCalculateItem>();
        }
        public CostCalculateSheet(string sheetName)
        {
            this.SheetName = sheetName;
            this.CostCalculateSheetList = new List<CostCalculateItem>();
        }

    }
}
