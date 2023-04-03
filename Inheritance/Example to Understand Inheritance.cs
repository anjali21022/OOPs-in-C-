using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inheritance
    {
        class A
        {
            public void Method1()
            {
                Console.WriteLine("Method 1");
            }
            public void Method2()
            {
                Console.WriteLine("Method 2");
            }
        }
        class B : A
        {
            static void Main()
            {
                B obj = new B();
                obj.Method1();
                obj.Method2();
                Console.ReadKey();
            }
        }
    }
}
