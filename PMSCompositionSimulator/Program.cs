using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PMSCompositionSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用成分模拟生成器Version2.0，请按照提示继续操作");
            bool isQuit = false;
            string input = "";

            try
            {
                while (!isQuit)
                {
                    try
                    {
                        string templateFile = Path.Combine(Environment.CurrentDirectory, "Template.txt");
                        Console.WriteLine("改写模板请按y再回车？");
                        input = Console.ReadLine();
                        if (input == "y")
                        {
                            Console.WriteLine("请按照特定模式改写模板，保存后关闭回车继续");
                            Process.Start(templateFile);
                            Console.WriteLine("模版改写后请保存,回车继续");
                            input = Console.ReadLine();
                        }

                        StreamReader sr = new StreamReader(templateFile);
                        int recordCount = int.Parse(sr.ReadLine());

                        string line = "";
                        List<SingleElement> elements = new List<SingleElement>();
                        //Read Data
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] arrays = line.Split('+');
                            SingleElement s = new SingleElement();
                            s.Element = arrays[0];
                            s.Ratio = double.Parse(arrays[1]);
                            s.Offset = double.Parse(arrays[2]);
                            elements.Add(s);
                        }
                        sr.Close();

                        //Process Data
                        double AllAt = elements.Sum(s => s.Ratio);
                        Random r = new Random();

                        for (int i = 0; i < recordCount; i++)
                        {
                            
                            for (int j = 0; j < elements.Count; j++)
                            {
                                var s = elements[i];
                            }
                        }



                        elements.ForEach(s =>
                        {
                            s.Average = s.RealValues.Average();
                        });





                        string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Data.csv");
                        StreamWriter sw = new StreamWriter(outputFile);
                        //write the title
                        sw.Write("No.");
                        elements.ForEach(s =>
                        {
                            sw.Write(",");
                            sw.Write(s.Element);
                        });
                        sw.WriteLine();

                        //write the content
                        for (int i = 0; i < recordCount; i++)
                        {
                            sw.Write(i + 1);
                            elements.ForEach(s =>
                            {
                                sw.Write(",");
                                sw.Write((s.RealValues[i]).ToString("F2"));
                            });
                            sw.WriteLine();
                        }

                        //write the average
                        sw.Write("Average");
                        elements.ForEach(s =>
                        {
                            sw.Write(",");
                            sw.Write((s.Average).ToString("F2"));
                        });
                        sw.WriteLine();

                        sw.Flush();
                        sw.Close();

                        Console.WriteLine("数据输出完毕");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("文件内容格式错误");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("ByeBye");
            }

        }
    }
}
