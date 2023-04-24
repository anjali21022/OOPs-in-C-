using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Class1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }
    class Class2 : Class1
    {
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1+ " "  +s2);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.7f);
            obj.Add("Anjali", "Chavan");
            Console.ReadKey();
        }
    }
}
