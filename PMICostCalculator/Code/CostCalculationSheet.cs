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
    /// 不要轻易更改这个类的成员名称和数量，否则对应的已经生成的xml文件会存在兼容性问题
    /// </summary>
    [Serializable]
    public class CostCalculationSheet
    {
        //成本计算类的名称
        public string SheetName { get; set; }

        //备注信息
        public string Remark { get; set; }

        //所有成本项目
        public List<CostItem> CostItemList{get;set;}

        public CostCalculationSheet()
        {
            this.CostItemList = new List<CostItem>();
        }

        public CostCalculationSheet(string sheetName,string remark)
        {
            this.SheetName = sheetName;
            this.Remark = remark;
            this.CostItemList = new List<CostItem>();
        }

    }
}
