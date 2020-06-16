using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson7Encapsulation;

namespace lesson7Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // public, private, internal, protected, internal protected
            Person person = new Person();
            Console.WriteLine(person.Getage());
            AnotherNamespaceClass anc = new AnotherNamespaceClass();
            Console.WriteLine(anc.internalstring);

            Man man = new Man();
            Console.WriteLine(man.GetPersonName());
            Console.WriteLine();
        }
    }

    class Person
    {
        private int age = 18;

        protected string name = "Jack";
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Getage()
        {
            if (checkAge())
            {
                return age;
            }
            return -1;
        }
        private bool checkAge()
        {
            if (age < 20)
            {
                return false;
            }
            return true;
        }
    }

    class Man : Person
    {
        public string GetPersonName()
        {
            return base.name;
        }
    }
}

