using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //object, string, dynamic
            //System.Object, 
            object o = new Object();
            o.GetType();
            o.ToString();
            //Console.WriteLine(o.GetType());
            int i = 5;
            //Console.WriteLine(i.ToString());
            String s = "1123";
            String s2 = "11";
            s2 += "22";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s == s2);
            Console.WriteLine((object)s == (object)s2);
            char c = s[2];
            Console.WriteLine(c);
            String u = "\\\u0066\n";
            Console.WriteLine(u);
            string at = @"c:\1234567897891234.cs";
            Console.WriteLine(at);
            string at2 = "c:\\aabb1234567897891234.cs";
            at.Contains("aabb");
            Console.WriteLine(at2);
            Console.WriteLine(at2.Length);
            Console.WriteLine(at2.IndexOf("1234"));

            StringBuilder builder = new StringBuilder();
            //builder.Append("oooo");
            //builder.Append("pppp");
            builder.AppendFormat("hello {0} {1}", "abcde", "world");
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
