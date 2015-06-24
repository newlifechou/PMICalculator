using System;
namespace PMICostCalculator
{
    /// <summary>
    /// 数据操作接口
    /// </summary>
    public interface ICostDataOperate
    {
        CostCalculateSheet Read(string fileName);
        void Save(string fileName, CostCalculateSheet sheet);
    }
}
