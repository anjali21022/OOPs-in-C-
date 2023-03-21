using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructors
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Creating instance of Child class
            Parents.Child obj = new Parents.Child();
            Console.ReadKey();
        }
    }
    public class Parents
    {
        //Private Constructor
        private Parents()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }
        public class Child : Parents
        {
            public Child()
            {
                Console.WriteLine("Child Class Public Constructor is Called");
            }
        }
    }
}
