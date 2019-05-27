using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1.Interface;

namespace Part1.Classes
{
    public abstract class ManagementStuff : Employee , IManagable
    {
        public void DoEmployeeApprisal(Employee e)
        {
            Console.WriteLine($"I'm doing apprisial on {e.Name} ");
        }
        public void PromoteEmployee(Employee e)
        {
            Console.WriteLine($"Promoting {e.Name}");
        }
        public abstract void SendCommunication();

        public abstract void Manage();

    }

    public class Director : ManagementStuff
    {
        public override void SendCommunication()
        {
            Console.WriteLine("Im the Director");
        }

        public override void Manage()
        {
            Console.WriteLine("Manageeeeee");
        }
    }

    public class Manager : ManagementStuff
    {
        public override void SendCommunication()
        {
            Console.WriteLine("Im the Manager");
        }

        public override void Manage()
        {
            Console.WriteLine("Manageeeeee");
        }
    }


}
