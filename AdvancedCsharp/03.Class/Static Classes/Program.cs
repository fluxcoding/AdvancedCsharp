using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    class Program
    {

        public static class GallonsToLitters
        {
            public static double GallonToLiter(double gallon)
            {
                return gallon * 3.7854;
            }

            public static double LiterToGallon(double liter)
            {
                return liter / 3.7854;
            }

        }


        static void Main(string[] args)
        {
            #region 1

            //double galoni = 10;

            //Console.WriteLine(GallonsToLitters.GallonToLiter(galoni));

            //Console.WriteLine($"Galoni vo litri: {GallonsToLitters.GallonToLiter(galoni)} galoni:{galoni}");

            //Console.ReadLine();
            #endregion

            string text = "Hi there, how are you?";

            Console.WriteLine(text.Shorten(8));
        }
    }
}
