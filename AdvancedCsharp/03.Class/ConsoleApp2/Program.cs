using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public string City { get; set; }
            public double Balance { get; set; }
            public string Address { get; set; }
        }

       public static void Print<T>(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                Console.WriteLine($"{prop.Name}\t");
                Console.WriteLine("\n");
            }
                foreach (var item in collection)
                {
                    foreach (var prop in props)
                    {
                    Console.WriteLine($"{prop.GetValue(item)}\t");
                    }
                Console.WriteLine("\n");
                }
            }
        

        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Name = "Customer1",City = "Skopje",Balance = 1000, Address = "Nekade"},
                 new Customer{Name = "Customer2",City = "Veles",Balance = 1500,Address ="sekade"}
            };

            Print(customers);


            Console.ReadLine();
        }
    }
}
