﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task myTask = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Hello there, after 2000ms!");
            //});

            //myTask.Start();

            //Task<string> myName = new Task<string>(()=> {

            //    Thread.Sleep(4000);
            //    Console.WriteLine("Hello from SEDC!");

            //    return "Hello my name is Teodor";

            //});

            //myName.Start();

            //Console.WriteLine(myName.Status);
            //Console.WriteLine(myName.Result);
            //Console.WriteLine(myName.Status);
            //Console.WriteLine("App end!");


            //Task<int> myIntTask = new Task<int>(() =>
            //{

            //    Thread.Sleep(3000);
            //    return 6;
            //});


            //Task.Run(()=> {

            //    Thread.Sleep(3000);
            //    Console.WriteLine("This is executed immidately!");

            //});


            for (int i = 0; i < 20; i++)
            {
                int temp = i;

                Task.Run(() => {

                    Thread.Sleep(2000);
                    Console.WriteLine("Task No. {0}",temp);
                });
            }


            Console.ReadLine();
        }




    }
}
