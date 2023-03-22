using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    internal class Creating_an_Instance_from_Outside_the_Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"PI : {Test.PI}");
            Console.WriteLine($"Square of 5 : {Test.GetSquare(5)}");
            Console.ReadKey();
        }
    }
    public static class Test
    {
        public static double PI = 3.14;
        public static int GetSquare(int x)
        {
            return x * x;
        }
    }
}
