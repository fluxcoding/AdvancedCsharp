using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            Box b1 = new Box(1, 1, 1);
            Console.WriteLine("Volume{0}",b1.Volume());

            Box b2 = new Box(2, 2, 3);
            //Console.WriteLine("Volume:{0}",b2.Volume());

            //Box b3;
            //b3 = b1 + b2;
            //Console.WriteLine("Volume:{0}",b3.Volume());

            //Box b4 = b2 - b1;
            //Console.WriteLine("Volume:{0}", b4.Volume());


            b1++;
            Console.WriteLine("Volume{0}", b1.Volume());

            b1--;
            Console.WriteLine("Volume{0}", b1.Volume());

            Box b5 = new Box(1, 1, 1);
            Box b6 = new Box(1, 1, 1);

            if (b5 == b6)
            {
                Console.WriteLine("Isti se");
            };

            if (b2 != b5)
            {
                Console.WriteLine("Razlicni se");
            }


            bool b = false;

            if (!b)
            {
                Console.WriteLine("True");
            }

            Box box = new Box(0, 0, 0);
            if (!box)
            {
                Console.WriteLine("prazna");
            }


            Console.ReadLine();

        }
    }
}
