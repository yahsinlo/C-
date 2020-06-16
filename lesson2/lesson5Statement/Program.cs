using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region condition
            bool condition = true;
            int ten = 31;
            object nullobject = null;
            if (ten > 20)
            {
                Console.WriteLine("true");
                if (true)
                {
                    Console.WriteLine("true+true");
                }
            }
            else if (ten > 8)
            {
                Console.WriteLine("elseif");
            }
            else
            {

            }
            int aaa = ten < 100 ? ten : 99;
            Console.WriteLine(aaa);

            int switchkey = 60;
            switch (switchkey)
            {
                case 10:
                    Console.WriteLine("switchkey is 10");
                    break;
                case 59:
                    Console.WriteLine("switchkey is 59");
                    break;
                default:
                    Console.WriteLine("all is wrong");
                    break;             
            }
            #endregion
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(i);
                if (i==3)
                {
                    continue;
                }
                Console.WriteLine("aaaa");
            }

            List<int> listint = new List<int>() {31, 32, 33 };
            foreach(var intlist in listint)
            {
                Console.WriteLine(intlist);
            }
            int n = 1;
            while(n++<6)
            {

                Console.WriteLine("n is {0}", n);
            }
            do
            {
                Console.WriteLine("time");
            } while (false);

            Console.WriteLine();

        }


        
    }
}
