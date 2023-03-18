using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_We_Need_Constructors
{
    internal class Define_a_Constructor_Explicitly1
    {
        class First
        {
            public int x = 101;
        }
        class Second
        {
            public int x;
        }
        class Test
        {
            static void Main(string[] args)
            {
                First f1 = new First();
                First f2 = new First();
                First f3 = new First();
                Console.WriteLine($"{f1.x} {f2.x} {f3.x}");

                Second s1 = new Second();
                Second s2 = new Second();
                Second s3 = new Second();
                Console.WriteLine($"{s1.x} {s2.x} {s3.x}");

                Console.ReadKey();
            }
        }
    }
}
