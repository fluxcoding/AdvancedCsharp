using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    public interface ICar
    {
        string MotorNumber { get; set; }

        void Refuel();
    }

    class Car : ICar
    {
        public string MotorNumber { get; set; }

        public void Refuel()
        {
            Console.WriteLine("This car drives on petrol.");
        }

        public Car()
        {
            MotorNumber = "00000000" + "-N";
        }

        public Car(string engineNumber)
        {
            MotorNumber = engineNumber + "-N"; // Normal car
        }

        //public string PrintInfo()
        //{
        //    return MotorNumber;
        //}



    }

    class ElectricCar : ICar
    {
        public string MotorNumber { get; set; }

        public int BateryLifeMonths { get; set; }

        public int BateryDuration { get; set; }

        public void Refuel()
        {
            Console.WriteLine("This car drives on battery.");
        }

        public ElectricCar()
        {
            MotorNumber = "00000000" + "-E";
        }

        public ElectricCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-N"; // Normal car
        }

        public ElectricCar(string engineNumber, int blf, int bd)
        {
            MotorNumber = engineNumber + "-N"; // Normal car
            BateryLifeMonths = blf;
            BateryDuration = bd;
        }

        public void PrintInfo()
        {
            Console.WriteLine(MotorNumber + " " + BateryLifeMonths + " " + BateryDuration);
        }

    }


    class HybridCar : ICar
    {
        public string MotorNumber { get; set; }

        public void Refuel()
        {
            Console.WriteLine("This car drives on both petrol and electricity.");
        }

        public HybridCar()
        {
            MotorNumber = "00000000" + "-EN";
        }

        public HybridCar(string engineNumber)
        {
            MotorNumber = engineNumber + "-EN"; // Normal car
        }

    }
}
