using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public static bool DividesDigitsSum(int n)
        {
            int sum = 0;

            while (n / 10 >0)
            {
                sum += n % 10;
            }
            return n % sum == 0;
        }

        delegate int lambda(int input);
        delegate long multiply(int x, int y, int z);
        delegate int nonParamsLambda();

        static void Main(string[] args)
        {

            lambda addOne = x => x + 1;

            nonParamsLambda random = () =>
            {
                int ran = new Random().Next();
                Console.WriteLine("Random number {0}",ran);
                return ran;
            };

            int myRandom = random();

            Action line = () => Console.WriteLine();


            IEnumerable<int> numbers = Enumerable.Range(10, 90);
            Console.WriteLine(string.Join(" ", numbers));

            long[] nums = {1,2,3,4,5};
            var parni_long = nums.Where(broj => broj % 2 == 0);


            var parni = numbers.Where(n => n % 2 == 0);
            var neparni = numbers.Where(n => n % 2 != 0);

            Console.WriteLine(string.Join(" ", parni));
            Console.WriteLine(string.Join(" ", neparni));


            var parni5 = numbers.Where(n => (n % 2 == 0 && n % 5 == 0));
            var neparn5 = numbers.Where((n => n % 2 != 0 && n % 5 == 0));



            string[] strings = { "zero", "one", "two", "three", "four"};

            string startsWithT = strings.First(s => s[0] == 't');
            Console.WriteLine(startsWithT);

            string startsWithE = strings.First(s => s.EndsWith("e"));
            string startsWithE2 = strings.First(s => s[s.Length-1] == 'e');


            // var something = strings.Where((broj,index) => broj == index);

            Console.ReadLine();

            // Where e kako Map
            // First

        }
    }
}
