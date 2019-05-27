using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class SparseArray
    {
        Dictionary<int, string> array = new Dictionary<int, string>();
        
        public string this[int i]
        {
            get
            {
                if (!array.ContainsKey(i))
                    return null;
                return array[i];
            }
            set
            {
                if (!array.ContainsKey(i))
                    array[i] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
