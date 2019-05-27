using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1.Interface;
using System.Threading;
using System.Threading.Tasks;

namespace Part1.Classes
{
    public abstract class ManagementStuff : Employee , IManagable
    {
        public void DoEmployeeApprisal(Employee e)
        {
            Logger.Log($"I'm doing apprisial on {e.Name} ");
        }
        public void PromoteEmployee(Employee e)
        {
            Logger.Log($"Promoting {e.Name}");
        }
        public abstract void SendCommunication();

        public abstract void Manage();

        private List<Employee> Vraboteni = new List<Employee>();

        public void AddSubEmployee(Employee e)
        {
             Vraboteni.Add(e);
            
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return Vraboteni;
        }

        public string EmailList
        {
            get { return string.Join(";", Vraboteni.Select(e => e.Email)); }
        }

        public override string ToString()
        {
            return base.ToString() + "Email list of employees: " + EmailList;
        }

        public void PromoteSubEmployees(int totalPromotionAmount)
        {
            if (Vraboteni.Count != 0)
            {
                var x = totalPromotionAmount / Vraboteni.Count;

                foreach (var item in Vraboteni)
                {
                    Logger.Log($"Salary of {item.Name} before promotion: {item.Salary}");
                    item.Salary += x;
                    Logger.Log($"Salary of {item.Name} after promotion: {item.Salary}");
                    
                }
            }
            else
            {
                
                Logger.Log("Zero employees");
            }
        }


    }

    public class Director : ManagementStuff
    {
        public override  void SendCommunication()
        {
            Logger.Log("Im the director");
        }


        public override void Manage()
        {
            Logger.Log("Manageeeeee");
        }
    }

    public class Manager : ManagementStuff
    {
        public override void SendCommunication()
        {
            Logger.Log("Im the Manager");
        }

        public override void Manage()
        {
            Logger.Log("Manageeeeee");
        }
    }


}
