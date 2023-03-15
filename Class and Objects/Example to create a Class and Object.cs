using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    internal class Class_and_Object
    {
        static void Main(string[] args)
        {
            // creating object
            Calculator calObject = new Calculator();
            //Accessing Calculator class member using Calculator class object
            int result = calObject.CalculateSum(10, 20);

            Console.WriteLine(result);
            Console.ReadKey();
        }
        //Defining class or blueprint or template
        public class Calculator
        {
            public int CalculateSum(int x, int y)
            {
                return x + y;
            }
        }
    }
}
