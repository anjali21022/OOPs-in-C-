using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program1
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 +" "+ s2);
        }
        
        static void Main(string[] args)
        {
            Program1 obj = new Program1();
            obj.Add(2, 5);
            obj.Add(3.1f, 5.0f);
            obj.Add("Anjali", "Chavan");
            Console.ReadKey();
        }
    }
}
