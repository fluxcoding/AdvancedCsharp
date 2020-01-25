using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Box
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int Lenght { get; set; }

        public Box() { }

        public Box(int width, int height, int lenght)
        {
            this.Width = width; this.Height = height; this.Lenght = lenght;
        }

        public int Volume()
            {
            return Width * Height * Lenght;
         }

        public static Box operator +(Box a,Box b)
        {
            Box c = new Box();
            c.Width = a.Width + b.Width;
            c.Height = a.Height + b.Height;
            c.Lenght = a.Lenght + b.Lenght;
            return c;
        }

        public static Box operator -(Box a, Box b)
        {
            Box c = new Box();
            c.Width = a.Width - b.Width;
            c.Height = a.Height - b.Height;
            c.Lenght = a.Lenght - b.Lenght;
            return c;
        }

        public static Box operator ++(Box a)
        {
            Box c = new Box();
            c.Width = a.Width + 1;
            c.Height = a.Height + 1;
            c.Lenght = a.Lenght + 1;

            return c;
        }

        public static Box operator --(Box a)
        {
            Box d = new Box();
            d.Width = a.Width - 1;
            d.Height = a.Height - 1;
            d.Lenght = a.Lenght - 1;

            return d;
        }

        public static bool operator ==(Box a, Box b)
        {
            return (a.Width == b.Width) && (a.Height == b.Height) && (a.Lenght == b.Lenght);
        }

        public static bool operator !=(Box a, Box b)
        {
            return (a.Width != b.Width) || (a.Height != b.Height) || (a.Lenght != b.Lenght);
        }

        public static bool operator !(Box a)
        {
            return (a.Width == 0 && a.Height == 0 && a.Lenght == 0);
        }

    }
}
