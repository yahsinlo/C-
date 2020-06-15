using System;

namespace lesson2
{
    enum Days {Monday, Tuesday, Wenesday, Thursday, Friday, Saurday, Sunday}
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int intValue = 0;
            int intValue2 = new int();
            bool a = true;

            Person person = new Person();
            person.age = 10;
            Console.WriteLine(person.age);
            var day = Days.Sunday;
            Console.WriteLine((int)day);
            Console.ReadLine();
        }
    }

    struct Person
    {
        public int age;
        public string name;
        public string fname;
        public string lastName;
    }
}