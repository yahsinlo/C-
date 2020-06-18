using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate  //等同C的指標
{
    delegate int Numberchanger(int n);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            //system.Delegate, delegate
            Numberchanger nc1 = new Numberchanger(Addnum);
            nc1(25);
            Console.WriteLine("value of Num {0}", num);

            Myclass mc = new Myclass();
            Numberchanger nc2 = new Numberchanger(mc.Addnum);
            nc2(35);
            Console.WriteLine("value of instance:{0}", mc.num);

            Numberchanger nc3 = new Numberchanger(mc.Multinum);
            nc3(2);
            Console.WriteLine("value of instance:{0}", mc.num);


            Console.ReadLine();
        }

        public static int Addnum(int p)
        {
            num += p;
            return num;
        }
    }
    class Myclass
    {
        public int num = 10;
        public int Addnum(int p)
        {
            num += p;
            return num;
        }
        public int Multinum(int p)
        {
            num *= p;
            return num;
        }
    }
}
