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

        public string Email { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"ID:{ID}\t Name:{Name}\t Surname:{Surname}\t Title:{Title}\t BirthD:{BirthDate}\n HireD:{HireDate}\t Email:{Email}\t Salary:{Salary}\t \n";
        }
    }



    public class Robot : Employee, IWorkable
    {
        public void MaintaingDatawareHouse()
        {
            Logger.Log("Beep boop beep boop");
        }

        public void Work()
        {
            Logger.Log("Working....");
        }
    }

    public class Accountant : Employee , IEatable , IManagable
    {
        public void MaintainAccounts()
        {
            Logger.Log("I maintain accounts");
        }

        public void Eat()
        {
            Logger.Log("Eating popcorn");
        }

        public void Manage()
        {
            Logger.Log("Managing some stuff over here");
        }
    }

    public class TechnicalStuff : Employee, IWorkable, IEatable
    {
        public void MaintainSystems()
        {
            Logger.Log("I maintain systems");
        }

        public void Work()
        {
            Logger.Log("Working so hard here");
        }

        public void Eat()
        {
            Logger.Log("Eating a hamburger");
        }
        
    }


}
