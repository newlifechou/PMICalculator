using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;

namespace ReadDensityDataFromDB
{
    /// <summary>
    /// 这个临时类用来从数据库读取密度数据，并生成xml数据文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string constr = "data source=192.168.16.254;initial catalog=db_new;uid=sa;pwd=123321tt";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from tb_density order by material";
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Console.WriteLine("Connection Ok");
                XDocument doc = new XDocument();
                XElement root=new XElement("Compounds");
                doc.Add(root);
                while (sdr.Read())
                {
                    XElement xe = new XElement("Compound", 
                        new XElement("Name",sdr.GetString(1)),
                        new XElement("Density",sdr.GetDouble(2))
                        );
                    root.Add(xe);
                }
                string filename=Path.Combine(Environment.CurrentDirectory,"Density.xml");
                doc.Save(filename);

                sdr.Close();

                Console.WriteLine("SuccessFully Done!");
                System.Diagnostics.Process.Start("explorer.exe", Environment.CurrentDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
