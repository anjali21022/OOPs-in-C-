using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    internal class Parameterized_Constructor
    {
        class Program
        {
            static void Main(string[] args)
            {
                ParameterizedConstructor obj = new ParameterizedConstructor(10);
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
