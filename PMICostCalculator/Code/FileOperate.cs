using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PMICostCalculator
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    public static class FileOperate
    {
        /// <summary>
        /// 判断文件夹里是否存在某个文件
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="dirpath"></param>
        /// <returns></returns>
        public static bool IsFileAlreadyExist(string filename,string dirpath)
        {
            bool isFileExist = false;
            DirectoryInfo dir = new DirectoryInfo(dirpath);
            foreach (var item in dir.GetFiles())
            {
                if (item.Name==filename+".xml")
                {
                    isFileExist = true;
                    break;
                }
            }
            return isFileExist;
        }
        /// <summary>
        /// 获取选定文件夹下的所有xml文件
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static List<FileInfo> GetFiles(string dirpath)
        {
            List<FileInfo> files = new List<FileInfo>() ;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirpath);
                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException("文件夹不存在");
                }
                foreach (var item in dir.GetFiles("*.xml"))
                {
                    files.Add(item);
                }
            }
            catch (Exception ex)
            {               
                throw ex;
            }
            return files;
        }
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
