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
                    string templateFile = Path.Combine(Environment.CurrentDirectory, "Template.txt");
                    Console.WriteLine("需要改写模板吗(y/n)？");
                    input = Console.ReadLine();
                    if (input=="y")
                    {
                        Console.WriteLine("请按照特定模式改写模板，保存后关闭回车继续");
                        Process.Start(templateFile);
                    }
                    Console.WriteLine("模版改写完毕,回车继续");
                    input=Console.ReadLine();

                    Console.WriteLine("(退出请输入exit)");
                    input = Console.ReadLine();
                    isQuit = (input == "exit");
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
