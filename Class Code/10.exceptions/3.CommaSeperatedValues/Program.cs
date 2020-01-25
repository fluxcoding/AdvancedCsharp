using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace _3.CommaSeperatedValues
{
    class Program
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }

        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>()
            {
                 new Customer{ID=1, Name = "Igor", City = "Skopje"},
                 new Customer { ID = 1, Name = "Igor", City = "Skopje" },
                 new Customer { ID = 1, Name = "Igor", City = "Skopje" }
            };

            //string path = @"C:\Users\teodor.bocevski\Desktop\Customers.csv";
            //using (StreamWriter sw = new StreamWriter(path))
            //    using(CsvWriter csv = new CsvWriter(sw))
            //{
            //    csv.WriteRecords(customers);
            //}

            string path = @"C:\Users\teodor.bocevski\Desktop\Customers.csv";
            using (StreamReader sr = new StreamReader(path))
            {
                using(CsvReader csvReader = new CsvReader(sr))
                {
                    var records = csvReader.GetRecords<Customer>();
                    foreach (var r in records)
                    {
                        Console.WriteLine($"{r.ID}{r.Name}{r.City}");
                    }
                }
               
            }

            Console.ReadLine();
        }
    }
}
