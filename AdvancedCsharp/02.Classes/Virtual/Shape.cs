using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
   public class Shape
    {
        protected double a { get; set; } = 1;
        protected double b { get; set; } = 1;
        protected double r { get; set; } = 1;

        public Shape () { }

        public Shape (double x, double y)
        {
            a = x; b = y;
        }

        public Shape(double radius)
        {
            r = radius;
        }

        public virtual double Area()
        {
            Console.WriteLine("Parent class area:");
            return a * b;
        }

    }

    public class Rectangle : Shape
    {
        //double a { get; set; }
        //double b { get; set; }
        // ne trebaat zoso se nasleduvaat od konkstruktorot

        public Rectangle() { }

        public Rectangle(double x, double y) : base(x, y)
        {
            a = x; b = y;
        }

        public override double Area()
        {
            Console.WriteLine("Rectangle class area");
            return a * b;
        }

    }

    public class Triangle : Shape
    {
        public Triangle() { }

        public Triangle(double x, double y) : base(x, y)
        {
            a = x; b = y;
        }

        public override double Area()
        {
            Console.WriteLine("Triangle class area");
            return a * b / 2;
        }

    }

    public class Circle : Shape
    {
        public Circle() { }

        public Circle(double rad) : base (rad)
        {
            r = rad;
        }

        public override double Area()
        {
            Console.WriteLine("Circle class area");
              return Math.PI * Math.Pow(r, 2);
          //  return Math.PI * r * r;
        }

    }



}
