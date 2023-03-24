using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    internal class External_Call_of_Destructor
    {
        public External_Call_of_Destructor()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~External_Call_of_Destructor()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            External_Call_of_Destructor obj1 = new External_Call_of_Destructor();
            External_Call_of_Destructor obj2 = new External_Call_of_Destructor();
            //Making obj1 for Garbage Collection
            obj1 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
