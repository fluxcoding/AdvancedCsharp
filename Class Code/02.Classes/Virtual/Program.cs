using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        class Caller
        {
            public void CallerArea(Shape s)
            {
                Console.WriteLine(s.Area());
            }
        }

        static void Main(string[] args)
        {

            Caller c = new Caller();



            Shape s1 = new Shape();
            Shape s2 = new Shape(4,5);
            //Console.WriteLine(s1.Area());
            //Console.WriteLine(s2.Area());
            c.CallerArea(s1);
            c.CallerArea(s2);
            Console.WriteLine("--------");

            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(5,6);
            //Console.WriteLine(r1.Area());
            //Console.WriteLine(r2.Area());
            c.CallerArea(r1);
            c.CallerArea(r2);
            Console.WriteLine("---------");

            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(4, 5);
            //Console.WriteLine(t1.Area());
            //Console.WriteLine(t2.Area());
            c.CallerArea(t1);
            c.CallerArea(t2);
            Console.WriteLine("--------");

            Circle c1 = new Circle();
            Circle c2 = new Circle(2);
            //Console.WriteLine(c1.Area());
            //Console.WriteLine(c2.Area());
            c.CallerArea(c1);
            c.CallerArea(c2);
            Console.WriteLine("--------");

            Console.ReadLine();

        }
    }
}
