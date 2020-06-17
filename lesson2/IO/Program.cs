using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\Test\3.txt"));//檔案有否存在
            Console.WriteLine(Directory.Exists(@"C:\")); //文件夾有否存在

            string path = "."; //'當前路徑
            if(args.Length>0)//找尋路徑下面的所有可執行文件
            {
                if(Directory.Exists(args[0]))
                {
                    path = args[0];
                }
                else
                {
                    Console.WriteLine("{0} not found; using current directory: ", args[0]);
                }               
            }
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach(FileInfo f in dir.GetFiles("*.pdb"))
            {
                string name = f.Name;
                long size = f.Length;
                DateTime dateTime = f.CreationTime;
                Console.WriteLine("{0,-12:N0} {1,-20:g} {2}", size, dateTime, name);
            }
            Console.WriteLine();
        }
    }
}
