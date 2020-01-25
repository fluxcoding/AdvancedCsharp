using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        class Student
        {
            public string FullName { get; set; }
            public int Age { get; set; }
            

        public Student(string name, int age)
        {
            FullName = name; Age = age;
        }

            public Student() { }

    }


        static void Main(string[] args)
        {
            Func<double> ddv = delegate { return 18.0; };
            Console.WriteLine("Tax rate: {0:F2}", ddv());


            Func<int,int,int,long> volume = delegate (int x, int y, int z) { return x * y * z; };
            Console.WriteLine(volume(2,3,4));


            Func<int, int, bool> isEqual = delegate (int a, int b) { return a == b; };
            Console.WriteLine(isEqual(2,2));

            Func<int, string, bool> isLongerThan = delegate (int len, string text) {
                return text.Length > len;
            };
            Console.WriteLine(isLongerThan(10,"CSharp advanced"));


            Student student = new Student { FullName = "Marko", Age = 19 };
            Student student2 = new Student ("Petar", 20 );
            Student student3 = new Student();
            student3.FullName = "Dejan";
            student3.Age = 23;

            Action line = () => Console.WriteLine();
            line();

            Func<Student, bool> isTeenage = delegate (Student s)
             {
                 return s.Age > 12 && s.Age < 20;
             };

            Func<Student, bool> isTeenage2 = (s) => (s.Age > 12 && s.Age < 20);
            Func<Student, bool> isTeenage3 = s => s.Age > 12 && s.Age < 20;

            Console.WriteLine(isTeenage(student));
            Console.WriteLine(isTeenage(student2));
            Console.WriteLine(isTeenage(student3));

            Console.ReadLine();
        }

        
    }
}
