using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class UmmanagedResource
    {
        public UmmanagedResource()
        {
            //Creating Unmanaged Resources  
            Console.WriteLine("Unmanaged Resource Created");
        }
        ~UmmanagedResource()
        {
            //Clean up Unmanaged Resources  
            Console.WriteLine("Unmanaged Resource Destroyed");
        }
    }
    class Program5
    {
        static void Main()
        {
            UmmanagedResource resource = new UmmanagedResource();
            Console.WriteLine("Using Unmanaged Resource");
            resource = null;
            GC.Collect();

            Console.ReadKey();
        }
    }
}
