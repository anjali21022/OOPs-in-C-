using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program1
    {
        static void Main()
        {
            //Creating Reference of an Interface point to the 
            //child class instance
            ITestInterface1 obj = new ImplementationClass();
            //Add method signature declared in ITestInterface1, so we can
            //Invoke the Add method
            obj.Add(10, 20);
            //Sub method signature is not declared in ITestInterface1, 
            //so, we cannot Invoke the Sub method
            //obj.Sub(100, 20);

            Console.ReadKey();
        }
    }
    interface ITestInterface1
    {
        void Add(int num1, int num2);
    }

    public class ImplementationClass : ITestInterface1
    {
        //Interface Method Implementation
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        //This method purely belongs to ImplementationClass
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
        }
    }
}
