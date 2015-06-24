using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;


namespace PMICostCalculator
{
    /// <summary>
    /// XML文件操作类
    /// TODO:后面考虑转换为继承接口，拓展数据库操作类出来
    /// 考虑使用xml文件的序列化来继续保存和读取
    /// 后面考虑将读和写的操作规范统一一下
    /// </summary>
    public class XMLDocOp : ICostDataOperate
    {
        /// <summary>
        /// 保存成本计算表数据到XML文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="sheet"></param>
        public void Save(string fileName,CostCalculationSheet sheet)
        {
            TextWriter tr = new StreamWriter(fileName);
            XmlSerializer xs = new XmlSerializer(typeof(CostCalculationSheet));
            xs.Serialize(tr, sheet);
            tr.Close();           
        }
        /// <summary>
        /// 从XML文件中读取数据并返回成本计算表
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public CostCalculationSheet Read(string fileName)
        {
            CostCalculationSheet ccs;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(CostCalculationSheet));
            ccs = (CostCalculationSheet)xs.Deserialize(fs);
            fs.Close();
            return ccs;
        }
    }
}
