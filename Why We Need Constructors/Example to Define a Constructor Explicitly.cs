using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_We_Need_Constructors
{
    internal class Define_a_Constructor_Explicitly
    {
        class First
        {
            public int x = 91;
        }
        class Test
        {
            static void Main(string[] args)
            {
                First f1 = new First();
                First f2 = new First();
                First f3 = new First();
                Console.WriteLine($"{f1.x} {f2.x} {f3.x}");
                Console.ReadKey();
            }
        }
    }
}
