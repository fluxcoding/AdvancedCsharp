using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _1.nez
{
   
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee()
            {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "123456",
                Skills = new List<string>() { "C#", "SQL Server" }
            };

            e1.SetPrivates("Ul.Partizanski odredi, Skopje");

            IFormatter formatter = new BinaryFormatter();
            string path = @"C:\Users\teodor.bocevski\Desktop\BinarySerialization.bin";

            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, e1);
            }

            Console.WriteLine("Deserialization ...");
            Employee dEmp;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                dEmp = (Employee)formatter.Deserialize(fs); 
            }
            Console.WriteLine(dEmp.ToString());


// ---------------------------------------------------------------------------------------------



            Employee e2 = new Employee()
            {
                ID = 2,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "2334435",
                Skills = new List<string>() { "C#", "CSS/HTML" }
            };

            e2.SetPrivates("Ul.kozle, Skopje");

            List<Employee> employees = new List<Employee>();
            employees.Add(e1);employees.Add(e2);


            IFormatter formatter2 = new BinaryFormatter();
            string path2 = @"C:\Users\teodor.bocevski\Desktop\ListSerialization.bin";

            using (FileStream fs = new FileStream(path2, FileMode.OpenOrCreate))
            {
                foreach (var item in employees)
                {
                    formatter2.Serialize(fs, item);
                }
            }

            //Console.WriteLine("Deserialization ...");
            //Employee dEmp;

            //using (FileStream fs = new FileStream(path, FileMode.Open))
            //{
            //    dEmp = (Employee)formatter.Deserialize(fs);
            //}
            //Console.WriteLine(dEmp.ToString());


        }
    }
}
