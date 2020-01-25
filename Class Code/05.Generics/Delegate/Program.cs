using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        public delegate string Delegation(string a);

        public delegate void Del(string msg);
        //Delegat


        static void Main(string[] args)
        {

            Delegation first = new Delegation(Neshto);
            string s1 = first("Prv delegat msg");
            Console.WriteLine(s1);


            Delegation second = new Delegation(Neshto2);
            string s2 = second("Vtor delegat msg");
            Console.WriteLine(s2);

            Del tirth = new Del(Neshto3);
            tirth("Tret delegat msg");


            Console.ReadLine();
        }

        // FUNKCII

        public static string Neshto(string msg)
        { return msg;}

        public static string Neshto2(string msg)
        {return msg;}

        public static void Neshto3(string str)
        {
            Console.WriteLine(str);
        }


    }

    

}
