using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

         //   Animal animal = new Animal();
         // Nemozeme da praime klonovi od abstraktnata klasa

            Dog dog = new Dog();

            Console.WriteLine(dog.Describe());
            Console.WriteLine(dog.Features());
            Console.WriteLine("--------------------");


            Console.ReadLine();

        }
    }
}
