using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPart2
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int MonthlySpend { get; set; }

        public Customer() { }

        public Customer(string name,string address,string city,int monthlyspend)
        {
            Name = name; Address = address; City = city; MonthlySpend = monthlyspend;
        }

        public void PrintCustomer()
        {
            Console.WriteLine($"Customer:{Name},{Address},{City},{MonthlySpend}");
        }

        public class CustomerMonthlySpendComparer : IComparer<Customer> {
            public int Compare(Customer c1, Customer c2)
            {
                return c1.MonthlySpend - c2.MonthlySpend;
            }

        }

        public class CustomerCityComparer : IComparer<Customer> {
            public int Compare(Customer c1, Customer c2)
            {
                return string.Compare(c1.City,c2.City);
            }


        }
    }
}
