using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_Non_Static_Constructors
{
    internal class Static_and_Non_Static_Constructor2
    {
        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            //Creating Object of ConstructorsDemo
            //Now the ConstructorsDemo class Execution Start
            //First, it will execute the Static constructor 
            //Then it will execute the non-static constructor
            ConstructorsDemo obj = new ConstructorsDemo();
            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
        public class ConstructorsDemo
        {
            static int x; //It is going to be initialized by static constructor
            int y; //It is going to be initialized by non-static constructor
                   //Static Constructor
            static ConstructorsDemo()
            {
                //This constructor initialized the static variable x with default value i.e. 0
                Console.WriteLine("Static Constructor is Called");
            }
            //Non-Static Constructor
            public ConstructorsDemo()
            {
                //This constructor initialized the static variable y with default value i.e. 0
                Console.WriteLine("Non-Static Constructor is Called");
            }
        }
    }
}
