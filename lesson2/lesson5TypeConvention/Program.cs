using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5TypeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = i;
            C1 c1 = new C2();

            double d = 10.05;
            int iFormD = (int)d;

            C1 c11 = new C1();

            try
            {
                C2 c2 = (C2)c11;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(c11 is C1);
            Console.WriteLine(c11 is C2);

            C2 c22 =  c11 as C2;
            Console.WriteLine(c22 == null);
            //int ias = "5" as int;

            //Console.WriteLine(iFormD);
            Console.WriteLine();
        }
        class C1
        {
        }

        class C2 : C1
        {
        }
    }
}
