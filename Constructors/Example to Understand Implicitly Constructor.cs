using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Implicitly_Constructor
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine($"i = {obj.i}");
            Console.WriteLine($"b = {obj.b}");

            //value null will be printed, so here we checking the null
            if (obj.s == null)
            {
                Console.WriteLine("s = null");
            }
            Console.ReadKey();
        }
    }
    class Test
    {
        public int i;
        public bool b;
        public string s;
    }
}

