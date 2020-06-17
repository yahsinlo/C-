using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOwrite
{
    class Program
    {
        private const string file_name = "Test.txt"; 
        static void Main(string[] args)
        {
            /*if (File.Exists(file_name))
            {
                Console.WriteLine("{0} already exist", file_name);//文件若存在就直接讀取
                Console.ReadLine();
                return;
            }

            FileStream fs = new FileStream(file_name, FileMode.Create);//文件名.文件打開模式
            BinaryWriter w = new BinaryWriter(fs);

            for (int i = 0; i < 11; i++)
            {
                w.Write("a");
            }
            w.Close();
            fs.Close();*/


            using (StreamWriter w = File.AppendText("test.txt"))//針對已存在之file寫入
            {
                Log("hello", w);
                Log("hello I am Anna",w);
                w.Close();
            }
        }

        public static void Log(String logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry:");
            w.Write(" :{0}", logMessage);
            w.Flush(); //清除此區buffer
        }
    }
}
