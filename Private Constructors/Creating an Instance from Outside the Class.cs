using Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructors
{
    internal class Creating_an_Instance_from_Outside_the_Class
    {
        static void Main(string[] args)
        {
            //Creating instance of Test class using public Constructor
            Test obj = new Test(10);
            obj.Method1();
            Console.ReadKey();
        }
    }
    public class Test
    {
        //Private Constructor
        private Test()
        {
            Console.WriteLine("This is Private Constructor");
        }
        //Public Constructor
        public Test(int x)
        {
            Console.WriteLine("This is public Constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 is Called");
        }
    }
}
