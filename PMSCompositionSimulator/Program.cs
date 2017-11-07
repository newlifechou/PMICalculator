using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PMSCompositionSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用成分模拟生成器Version2.0，请按照提示继续操作");
            bool isQuit = false;
            string input = "";
            while (!isQuit)
            {
                bool isLast = false;
                List<SingleElement> elements = new List<SingleElement>();

                try
                {
                    int recordCount = 5;
                    Console.WriteLine("请输入需要的记录总数");
                    input = Console.ReadLine();
                    int.TryParse(input, out recordCount);

                    while (!isLast)
                    {
                        Console.WriteLine("请输入名称并回车(字符)");
                        input = Console.ReadLine();
                        var tempElement = new SingleElement();
                        tempElement.Element = input;

                        Console.WriteLine("请输入比例并回车(数字)");
                        input = Console.ReadLine();
                        double at = 0;
                        double.TryParse(input, out at);
                        tempElement.Ratio = at;

                        Console.WriteLine("请输入偏差(数字)(默认是0.5)");
                        input = Console.ReadLine();
                        double offset = 0.5;
                        double.TryParse(input, out offset);
                        tempElement.Offset = offset;

                        elements.Add(tempElement);

                        Console.WriteLine("结束请输入ok");
                        isLast = (input == "ok");
                    }
                    //calculate it
                    double allAt = elements.Sum(s => s.Ratio);
                    elements.ForEach(i =>
                    {
                        i.Ratio = i.Ratio / allAt;
                    });

                    string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), DateTime.Now.ToString() + ".csv");
                    StreamWriter sw = new StreamWriter(outputFile);
                    sw.Write("No.");
                    elements.ForEach(i => {
                        sw.Write(",");
                        sw.Write(i.Element);
                    });
                    sw.WriteLine();

                    Random r = new Random();

                    sw.Flush();
                    sw.Close();

                    Console.WriteLine("csv文件在桌面上");
                }
                catch (Exception)
                {

                }
                finally
                {
                    elements.Clear();
                }


                Console.WriteLine("(退出请输入exit)");
                isQuit = (input == "exit");
            }
        }
    }
}
