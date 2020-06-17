using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9Polymorphism
{
    class Program 
    {
        static void Main(string[] args)
        {
            printhello();
            printhello("world");

            complex c1 = new complex();
            complex c2 = new complex();
            c1.number = 2;
            c2.number = 5;
            Console.WriteLine((c1 + c2).number);

            human human1 = new man();
            human human2 = new woman();
            human1.cleanroom();
            human2.cleanroom();
            Console.WriteLine(c2.ToString());
            Console.WriteLine();
        }

        public static void printhello()
        {
            Console.WriteLine("Hello");
        }
        public static void printhello(string towho)
        {
            Console.WriteLine("Hello {0}", towho);
        }

    }
    class complex
    {
        public int number { get; set; }

        public static complex operator +(complex C1, complex c2)
        {
            complex c = new complex();
            c.number = C1.number + c2.number;
            return c;
        }
        public override string ToString()
        {
            return number.ToString();
        }
    }

    class human
    {
        public virtual void cleanroom()
        {
            Console.WriteLine("human clean room");
        }
    }
    class man : human
    {
        public override void cleanroom()
        {
            Console.WriteLine("man clean room slowly");
        }
    }
    class woman : human
    {
        public override void cleanroom()
        {
            Console.WriteLine("woman clean room quickly");
        }
    }
}
