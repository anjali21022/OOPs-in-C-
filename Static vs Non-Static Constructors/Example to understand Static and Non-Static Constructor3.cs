using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_Non_Static_Constructors
{
    internal class Static_and_Non_Static_Constructor3
    {
        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            //As soon as it finds ConstructorsDemo.x, 
            //it will first execute the static constructor of the class
            Console.WriteLine(ConstructorsDemo.x);
            Console.WriteLine("Main Method Completed");
            Console.ReadKey();
        }
        public class ConstructorsDemo
        {
            public static int x; //It is going to be initialized by static constructor
            public int y; //It is going to be initialized by non-static constructor

            //Static Constructor
            static ConstructorsDemo()
            {
                //This constructor initialized the static variable x with default value i.e. 0
                Console.WriteLine("Static Constructor is called");
            }

            //Non-Static Constructor
            public ConstructorsDemo()
            {
                //This constructor initialized the static variable y with default value i.e. 0
                Console.WriteLine("Non-Static Constructor is called");
            }
        }

    }
}
