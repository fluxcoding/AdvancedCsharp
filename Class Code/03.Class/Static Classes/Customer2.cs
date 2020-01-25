using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
   public partial class Customer
    {
        partial void PrintCustomerInfo()
        {
            Console.WriteLine($"{Name} + {Adress}");
        }

        public void Print()
        {
            PrintCustomerInfo();
        }
    }
}
