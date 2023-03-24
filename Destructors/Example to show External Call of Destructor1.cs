using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    internal class External_Call_of_Destructor1
    {
        public External_Call_of_Destructor1()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~External_Call_of_Destructor1()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            External_Call_of_Destructor1 obj1 = new External_Call_of_Destructor1();
            External_Call_of_Destructor1 obj2 = new External_Call_of_Destructor1();
            //Making obj1 for Garbage Collection
            obj1 = null;
            obj2 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
