using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("This is private constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Main method");
            Console.ReadKey();
        }
    }
}
