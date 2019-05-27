using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1.Classes;


namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region classes

            Director d1 = new Director {
                ID = 3,
                Name = "Bob",
                Surname = "Bobski",
                Title = "Director",
                BirthDate = new DateTime(1995,10,03),
                HireDate =  new DateTime(2002,12,05)
            };

            Manager m1 = new Manager
            {
                ID = 3,
                Name = "Toshe",
                Surname = "Malerot",
                Title = "Manager",
                BirthDate = new DateTime(1995, 10, 03),
                HireDate = new DateTime(2002, 12, 05)
            };

            Robot r1 = new Robot
            {
                ID = 3,
                Name = "Robo",
                Surname = "Cop",
                Title = "Robot",
                BirthDate = new DateTime(1995, 10, 03),
                HireDate = new DateTime(2002, 12, 05)
            };

            Accountant a1 = new Accountant
            {
                ID = 3,
                Name = "Ema",
                Surname = "Watson",
                Title = "Accountant",
                BirthDate = new DateTime(1995, 10, 03),
                HireDate = new DateTime(2002, 12, 05)
            };

            TechnicalStuff t1 = new TechnicalStuff
            {
                ID = 3,
                Name = "Mike",
                Surname = "Spike",
                Title = "TechnicalStuff",
                BirthDate = new DateTime(1995, 10, 03),
                HireDate = new DateTime(2002, 12, 05)
            };

            #endregion


            d1.PromoteEmployee(r1);
            d1.DoEmployeeApprisal(r1);
            d1.PromoteEmployee(a1);
            d1.DoEmployeeApprisal(a1);
            a1.MaintainAccounts();
            t1.MaintainSystems();
            r1.MaintaingDatawareHouse();

            r1.Work();

            Console.ReadLine();
        }
    }
}
