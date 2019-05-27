using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Employee
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public DateTime Date { get; set; }
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            Type typeOf = typeof(T);

            if (!(typeOf.IsPrimitive || typeOf.IsValueType || typeOf == typeof (string)))
            {
                Console.WriteLine("------------------------");
                var props = typeof(T).GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine($"{prop.Name}\t");
                   
                }
                Console.WriteLine();
                foreach (var item in collection)
                    {
                        foreach (var prop in props)
                        {
                        Console.WriteLine($"{prop.GetValue(item,null)}\t");
                        }
                    
                    }
                Console.WriteLine();

            } else
            {
                Console.WriteLine("------------------------");
                foreach (var item in collection)
                {
                    Console.WriteLine($"{item}\t");
                }
                Console.WriteLine("\n");
            }
        }

        



        public static List <T> BuildList<T>(params T[] items)
        {

            return new List<T>(items);
        }




        static void Main(string[] args)
        {

            List<int> ints = BuildList<int>(1,2,3);

            Print(ints);

            List<string> strings = BuildList<string>("Hi,", "we're", "coding");

            Print(strings);

            List<Customer> customers = BuildList<Customer>(
            new Customer { ID = 1, Name = "SEDC" },
            new Customer { ID = 2, Name = "Sedc" }
            );

            Print(customers);


            Stack<int> intStack = new Stack<int>();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            Print(intStack);




            Console.ReadLine();


        }

        
 

    }
}
