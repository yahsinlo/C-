using System;

namespace Indexer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var names = new IndexNames();
            names[0] = "Apple";
            names[1] = "Banana";
            names[2] = "Cherry";
            names[3] = "Durian";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(names[i]);//列印資料
            }
            Console.WriteLine(names["Apple"]); //找到Apple在第0位
            Console.WriteLine(names["Durian"]);//找到Durian在第3位
            Console.WriteLine(names["Kiwi"]); //找不到Kiwi則回傳-1
        }
    }

    internal class IndexNames
    {
        private string[] namelist = new string[10]; //區域變數

        public IndexNames()
        {
            for (int i = 0; i < namelist.Length; i++)
            {
                namelist[i] = "N/A";
            }
        }

        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index <= namelist.Length - 1)
                {
                    temp = namelist[index];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }
            set//若+private, 則只能在此class使用
            {
                if (index >= 0 && index <= namelist.Length - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        public int this[string name] //找字串在第幾個位置
        {
            get
            {
                int index = 0;
                while (index < namelist.Length)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }

    public interface ISomeInterface
    {
        int this[int index]
        {
            get;
            set;
        }
    }

    internal class IndexerClass : ISomeInterface
    {
        private int[] arr = new int[100];

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
}