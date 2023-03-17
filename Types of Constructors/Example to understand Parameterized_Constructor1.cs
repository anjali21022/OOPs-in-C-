using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    internal class Parameterized_Constructor1
    {
        class Program
        {
            static void Main(string[] args)
            {
                ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
                ParameterizedConstructor obj2 = new ParameterizedConstructor(30);
                Console.ReadKey();
            }
        }
        public class ParameterizedConstructor
        {
            public ParameterizedConstructor(int i)
            {
                Console.WriteLine("Parameterized Constructor is called : " + i);
            }
        }
    }
}
