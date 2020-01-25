using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
           // SendMessages();

            SendMessagesWithThreads();
        }

        public static void SendMessages()
        {
            Console.WriteLine("Getting Ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("The app has finished!");
            Console.ReadLine();
        }

        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting Ready...");

            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });

            myThread.Start();


            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Third message arrived!");
            }).Start();


            Console.WriteLine("All messages have been received!");
            Console.ReadLine();
        }
    }
}
