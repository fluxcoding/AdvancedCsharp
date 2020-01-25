using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.exception
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num = 10;
            int divisor = 0;
            int calculated;

            try
            {
                calculated = num / divisor;
            }
            catch (Exception ex)
            {
                ex.HelpLink = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch";
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine("Bad result {0}",ex.HResult);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
    
            } finally
            {
                Console.WriteLine("Cleaning up some resources");
            };


            Console.ReadLine();
        }
    }
}
