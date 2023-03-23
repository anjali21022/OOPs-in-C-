using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructors
{
    internal class Private_Constructor_Restricting_Inheritance
    {
        static void Main(string[] args)
        {
            //Creating instance of Child class
            Child obj = new Child();
            Console.ReadKey();
        }
    }
    public class Parent
    {
        //Private Constructor
        private Parent()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }
        //Public Constructor
        public Parent(string Message)
        {
            Console.WriteLine("Parent Class Public Constructor is Called");
        }
    }
    public class Child : Parent
    {
        public Child() : base("Hello")
        {
            Console.WriteLine("Child Class Public Constructor is Called");
        }
    }
}
