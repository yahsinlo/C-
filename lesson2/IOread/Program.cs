using System;
using System.IO;

namespace IOread
{
    class Program
    {
        private const string File_name = "Test.txt";
        static void Main(string[] args)
        {
            if (!File.Exists(File_name))
            {
                Console.WriteLine("{0} doesn't exist", File_name);
                Console.ReadLine();
                return;
            }

            using (StreamReader sr = File.OpenText(File_name))
            {
                string input;
                while((input = sr.ReadLine()) != null)//每一行讀取，若為空則不再動作
                {
                    Console.WriteLine(input);
                }
                Console.Write("the end of the file");
                sr.Close();
            }
            FileStream fs = new FileStream(File_name, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            for (int i = 0; i < 11; i++)
            {
               // Console.WriteLine(r.ReadString());
            }
            r.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}
