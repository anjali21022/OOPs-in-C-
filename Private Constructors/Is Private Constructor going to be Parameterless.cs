using System;
namespace PrivateConstructorDemo
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("Private Parameterless Constructor is Called");
        }
        private Program(string message)
        {
            Console.WriteLine("Private Parameterized Constructor is Called");
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program("Hello");
            Console.ReadKey();
        }
    }
}