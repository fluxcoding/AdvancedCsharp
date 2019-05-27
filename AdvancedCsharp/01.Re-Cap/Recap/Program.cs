using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> Countries = new Dictionary<string, string>() {
                {"Macedonia", "Skopje"},
                {"Serbia", "Belgrade"},
                {"Germany", "Berlin"},
                {"Portugal", "Lisabon"}};


            while (true)
            {

                Console.WriteLine("Enter a country to find out the capital City");

                string selection = Console.ReadLine();

                foreach (var item in Countries)
                {

                    if ((item.Key.ToLower()) == (selection.ToLower()))
                    {
                        Console.WriteLine(item.Value);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no such a country!");
                        break;
                    }

                }

            }


            

            Console.ReadLine();








        }

        
    }
}
