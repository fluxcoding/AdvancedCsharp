using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Car car1 = new Car();

            Car car2 = new Car("223432KFG");

            Console.WriteLine(car1.MotorNumber);

            Console.WriteLine(car2.MotorNumber);

            Console.WriteLine("---------------");

            ElectricCar ecar1 = new ElectricCar();

            ElectricCar ecar2 = new ElectricCar("ASDAS3434S");

            Console.WriteLine(ecar1.MotorNumber);

            Console.WriteLine(ecar2.MotorNumber);

            Console.WriteLine("---------------");

            HybridCar hcar1 = new HybridCar();

            HybridCar hcar2 = new HybridCar("ASD:AKFHIOSDHFGIOSHDGIOFh");

            Console.WriteLine(hcar1.MotorNumber);

            Console.WriteLine(hcar2.MotorNumber);



            Console.ReadLine();

        }
    }
}
