using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic //泛型
{
    delegate T Numberchanger<T>(T n);

    class Program
    {
        static int n = 10;
        public static int AddNum(int p)
        {
            n += p;
            return n;
        }

        static void Main(string[] args)
        {
            Numberchanger<int> nc1 = new Numberchanger<int>(AddNum);
            nc1(88);
            Console.WriteLine(n);  //88+n - 88+10

            MygenericArray < int> intArray = new MygenericArray<int>(5);
            for (int c=0; c<5;c++)
            {
                intArray.SetItem(c, c * 5);

            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.GetItem(c)+" ");
            }
            Console.WriteLine();

            intArray.GenericMethod<string>("Hallo");

            MygenericArray<char > charArray = new MygenericArray<char>(5);
            for (int c = 0; c < 5; c++)
            {
                charArray.SetItem(c, (char)(c+97));

            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.GetItem(c) + " ");
            }
            Console.WriteLine();
        }
    }

    public class MygenericArray<T> where T:struct
    {
        private T[] array;
        public MygenericArray(int size)
        {
            array = new T[size + 1]; //初始化
        }
        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
        public void GenericMethod<X>(X x)
        {
            Console.WriteLine(x.ToString());
        }
    }
}
