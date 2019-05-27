using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    public static class Extensions
    {
        public static string Shorten(this string text,int length)
        {
            return text.Substring(0, length);
        }

        public static string QuiteString(this string str)
        {
            return '"' + str + '"';
        }

        
    }
}
