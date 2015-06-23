﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace PMICostCalculator
{
    /// <summary>
    /// XML文件操作类
    /// TODO:后面考虑转换为继承接口，拓展数据库操作类出来
    /// 考虑使用xml文件的序列化来继续保存和读取
    /// </summary>
    public class XMLDocOp
    {
        /// <summary>
        /// 保存成本计算表数据到XML文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="sheet"></param>
        public void SaveToXMLDoc(string fileName,CostCalculateSheet sheet)
        {

        }
        /// <summary>
        /// 从XML文件中读取数据并返回成本计算表
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public CostCalculateSheet ReadFromXMLDoc(string fileName)
        {
            return null;
        }
    }
}
