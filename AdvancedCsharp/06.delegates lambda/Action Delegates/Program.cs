using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegates
{
    class Program
    {

       class Student
        {
            public string FullName { get; set; }
            public int Age { get; set; }

        }


        static void Main(string[] args)
        {

            Action<string> showMessage = delegate (string msg) { Console.WriteLine(msg); };
            showMessage("Hello");


            Action line = () => Console.WriteLine();
            Action line2 = delegate { Console.WriteLine(); };
            Action line3 = delegate () { Console.WriteLine(); };

            line();
            line2();
            line3();

            Student student = new Student { FullName = "Teodor", Age = 23 };
            Action<Student> printStudentInfo = delegate (Student s)
            {
                Console.WriteLine("Name: {0}, Age: {1}", s.FullName,s.Age);
            };

            printStudentInfo(student);


            Action<Student> PrinStudentInfo2 = s => Console.WriteLine("Name: {0}, Age: {1}", s.FullName, s.Age);

            PrinStudentInfo2(student);


            Console.ReadLine();

        }
    }
}
