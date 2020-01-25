using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1.Interface;

namespace Part1.Classes
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            return $"{ID}\t{Name}\t{Surname}\t{Title}\t{BirthDate}\t{HireDate}\t";
        }
    }



    public class Robot : Employee, IWorkable
    {
        public void MaintaingDatawareHouse()
        {
            Console.WriteLine("Beep boop beep boop");
        }

        public void Work()
        {
            Console.WriteLine("Working....");
        }
    }

    public class Accountant : Employee , IEatable , IManagable
    {
        public void MaintainAccounts()
        {
            Console.WriteLine("I maintain accounts");
        }

        public void Eat()
        {
            Console.WriteLine("Eating popcorn");
        }

        public void Manage()
        {
            Console.WriteLine("Managing some stuff over here");
        }
    }

    public class TechnicalStuff : Employee, IWorkable, IEatable
    {
        public void MaintainSystems()
        {
            Console.WriteLine("I maintain systems");
        }

        public void Work()
        {
            Console.WriteLine("Working so hard here");
        }

        public void Eat()
        {
            Console.WriteLine("Eating a hamburger");
        }
        
    }


}
