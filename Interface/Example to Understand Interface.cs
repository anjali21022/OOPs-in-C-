using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main()
        {
            ImplementationClass1 obj = new ImplementationClass1();
            //Using obj we can only call Add method
            obj.Add(23, 56);
            //We cannot call Sub

            ImplementationClass2 obj1 = new ImplementationClass2();
            //Using obj2 we can call both Add and Sub method
            obj1.Add(12, 34);
            obj1.Sub(56, 19);   
        }
    }
    interface Interface1
    {
        void Add(int num1, int num2);
    }
    interface Interface2 : Interface1
    {
        void Sub(int num1, int num2);
    }
    public class ImplementationClass1 : Interface1
    {
        //Implement only the Add method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
    public class ImplementationClass2 : Interface2
    {
        //Implement Both Add and Sub method
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
}

