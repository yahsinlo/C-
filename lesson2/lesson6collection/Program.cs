using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.array
            #region array
            int[] numbers = new int[5];
            string[,] names = new string[5, 4];
            byte[][] scores = new byte[5][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("length of row{0} is {1}", i, scores[i].Length);
            }

            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers4 = { 1, 2, 3, 4, 5 };
            string[,] name2 = { { "g", "k" }, { "h", "j" } };
            int[][] numberss = { new int[] { 1, 2, 3, }, new int[] { 4, 5, 6, 7 } };
            Console.WriteLine(numbers2[2]);
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }
            #endregion
            ArrayList al = new ArrayList();
            al.Add(85);
            al.Add(80);
            al.Add("12345");
            foreach (var e in al)
            {
                Console.WriteLine(e);
            }

            List<int> intList = new List<int>();
            intList.Add(50);
            intList.AddRange(new int[] { 49, 50 });
            Console.WriteLine(intList.Contains(200)); //有無包含200
            Console.WriteLine(intList.LastIndexOf(50)); //50在第幾位
            intList.Remove(50);

            Hashtable ht = new Hashtable();
            ht.Add("first", "apple");
            ht.Add("third", "banana");
            ht.Add(159, 104);
            Console.WriteLine(ht["third"]);
            Console.WriteLine(ht[159]);
            Console.WriteLine(ht[99]); //無效，返回空值

            Dictionary<String, String> d = new Dictionary<string, string>();
            d.Add("first", "pencle");
            //d.Add(159, 104);

            SortedList<int, int> s1 = new SortedList<int, int>();
            s1.Add(5, 105);
            s1.Add(2, 102);
            s1.Add(10, 99);
            foreach (var sle in s1)
            {
                Console.WriteLine(sle.Value);
            }

 
            Console.ReadLine();
        }
    }
}
