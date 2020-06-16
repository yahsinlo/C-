using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dog dog = new Dog();
            dog.Age = 10;
            dog.Getage();
            dog.Bite();
            dog.Biteman();
            Dog dog2 = new Dog(50);*/


            Animal dog = new Dog();
            //dog.Bite();//****print: Animal constructor, Dog constructor, Dog bite 
            //dog.Biteman();//****print: Animal constructor, Dog constructor, Animal bites man (無override
            ((Dog)dog).Biteman();//****print: Animal constructor, Dog constructor, Dog bites man
            Console.WriteLine();
        }
        class Animal
        {
            public int Age
            {
                get;
                set;

            }

            public Animal()
            {
                Console.WriteLine("Animal constructor");
            }
            public Animal(int Age)
            {
                Console.WriteLine("Animal age");
                this.Age = Age;
            }
            public virtual void Getage()
            {
                Console.WriteLine(Age);
            }
            public virtual void Bite()
            {
                Console.WriteLine("Animal bite");
            }
            public void Biteman()
            {
                Console.WriteLine("Animal bites eman");
            }
        }
        sealed class Dog : Animal //sealed:防止其他類別繼承此class
        {
            public Dog()
            {
                Console.WriteLine("Dog constructor");
            }

            //public Dog(int Age) //*****print: Animal constructor, Dog age
            //public Dog(int Age) : base(Age) //****printf: Animal age, Dog age
            public Dog(int Age) : this() //****print: Animal constructor, Dog constructor, Dog age
            {
                Console.WriteLine("Dog age");
                this.Age = Age;
            }
            public override void Bite()
            {
                Console.WriteLine("Dog bite");
            }
            public new void Biteman()  //無virtual修飾詞及需new
            {
                Console.WriteLine("Dog bites eman");
            }
        }
    }
}
