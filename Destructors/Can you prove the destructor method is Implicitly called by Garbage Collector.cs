using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    internal class DestructorDemo1
    {
        public DestructorDemo1()
        {
            Console.WriteLine("DestructorDemo Object Created");
        }
        ~DestructorDemo1()
        {
            Console.WriteLine("DestructorDemo Object Destroyed");
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Started");
            DestructorDemo1 demo = new DestructorDemo1();

            //Making obj1 ready for Garbage Collection
            demo = null;
            GC.Collect();
            Console.WriteLine("Some Statement Executed Inside Main Method");
            demo = null;
            GC.Collect();
            Console.WriteLine("Some More Statement Executed Inside Main Method");
            GC.Collect();
            Console.WriteLine("Main Method Execution End");
            Console.ReadKey();
        }
    }
}
