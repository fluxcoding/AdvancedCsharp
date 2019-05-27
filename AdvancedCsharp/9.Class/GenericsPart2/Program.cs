using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Teo", "Boc", "Skopje", 30000);
            Customer c2 = new Customer("Leo", "Boc", "Veles", 20000);
            Customer c3 = new Customer("Stefan", "Boc", "Skopje", 10000);
            Customer c4 = new Customer("Goce", "Boc", "Bitola", 50000);
            Customer c5 = new Customer("Mirce", "Boc", "Skopje", 50000);


            Customer[] customers = new Customer[] { c1, c2, c3, c4, c5 };

            Array.Sort(customers, new CustomerMonthlySpendComparer());

        }
    }
}
