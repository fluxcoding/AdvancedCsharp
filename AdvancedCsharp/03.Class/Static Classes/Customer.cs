using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    public partial class Customer
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        partial void PrintCustomerInfo();


    }
}
