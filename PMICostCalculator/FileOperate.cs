using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMICostCalculator
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    public static class FileOperate
    {
        /// <summary>
        /// 判断文件名是否合法
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsValideFileName(string fileName)
        {
            bool isValid = true;
            string errChar = "\\/:*?\"<>|";
            if (string.IsNullOrEmpty(fileName))
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < errChar.Length; i++)
                {
                    if (fileName.Contains(errChar[i].ToString()))
                    {
                        isValid=false;
                        break;
                    }
                }
            }
            return isValid;
        }
    }
}
