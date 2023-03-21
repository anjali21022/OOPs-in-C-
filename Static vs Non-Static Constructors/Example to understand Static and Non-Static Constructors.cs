using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_vs_Non_Static_Constructors
{
    internal class Static_and_Non_Static_Constructors
    {
        static int x; //It is going to be initialized by static constructor
        int y; //It is going to be initialized by non-static constructor

        //Static Constructor
        static Static_and_Non_Static_Constructors()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is called");
        }

        //Non-Static Constructor
        public Static_and_Non_Static_Constructors()
        {
            //This constructor initialized the static variable y with default value i.e. 0
            Console.WriteLine("Non-static Constructor is called");
        }

        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            //Before Executing the body of Main Method, Static Constructor is executed
            Console.WriteLine("Main Method Body...");
            Console.ReadKey();
        }
    }
}
