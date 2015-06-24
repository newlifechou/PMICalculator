using System;
namespace PMICostCalculator
{
    /// <summary>
    /// 数据操作接口
    /// </summary>
    public interface ICostDataOperate
    {
        CostCalculationSheet Read(string fileName);
        void Save(string fileName, CostCalculationSheet sheet);
    }
}
