using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    internal class Parameterized_Constructor2
    {
        class Program
        {
            static void Main(string[] args)
            {
                ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
                obj1.Display();
                ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
                obj2.Display();
                Console.ReadKey();
            }
        }
        public class ParameterizedConstructor
        {
            int x;
            public ParameterizedConstructor(int i)
            {
                Console.WriteLine($"Parameterized Constructor is Called : {i}");
            }
            public void Display()
            {
                Console.WriteLine($"Value of X = {x}");
            }
        }
    }
}
