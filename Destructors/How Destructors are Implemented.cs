using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{   
        public class First
        {
            ~First()
            {
                Console.WriteLine("Destructor of First Class");
            }
        }
        public class Second : First
        {
            ~Second()
            {
                Console.WriteLine("Destructor of Second Class");
            }
        }
        public class Third : Second
        {
            ~Third()
            {
                Console.WriteLine("Destructor of Third Class");
            }
        }    
    class Program4
    {
        static void Main(string[] args)
        {
            Third obj = new Third();
            obj = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
