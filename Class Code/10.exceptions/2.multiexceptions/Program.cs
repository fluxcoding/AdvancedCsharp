using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.multiexceptions
{
    class Program
    {


        public class MultiExceptions
        {

            public void Run()
            {
                try
                {
                    this.ExceptionCollection(1, 2);
                }
                catch (AggregateException agrEx)
                {

                    foreach (var ex in agrEx.InnerExceptions)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }



            public void ExceptionCollection (int input1,int input2)
            {
                List<Exception> exceptions = new List<Exception>();
                if (input1 == 1)
                {
                    exceptions.Add(new ArgumentException("New argument ex"));
                }
                if (input2 == 2)
                {
                    exceptions.Add(new NullReferenceException("Null reference ex"));
                }
                if (exceptions.Any())
                {
                    throw new AggregateException("This is aggregated exception", exceptions);
                }
            }


        }



        static void Main(string[] args)
        {

            MultiExceptions multiExceptions = new MultiExceptions();
            multiExceptions.Run();



            Console.ReadLine();
        }
    }
}
