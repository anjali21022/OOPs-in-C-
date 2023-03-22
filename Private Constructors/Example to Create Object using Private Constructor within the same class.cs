using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_of_Constructors;

namespace Private_Constructors
{
    internal class Program
    {
        //Private Constructor
        private Program()
        {
            Console.WriteLine("Private Constructor is called");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 is called");
        }
        static void Main(string[] args)
        {
            //Creating instance of Program class using Private Constructor
            Program obj = new Program();
            obj.Method1();
            Console.ReadKey();
        }
    }
}
