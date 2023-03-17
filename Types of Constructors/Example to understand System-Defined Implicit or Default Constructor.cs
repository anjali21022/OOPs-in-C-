using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    internal class System_Defined_Implicit_or_Default_Constructor
    {
        class Employee
        {
            public int Id, Age;
            public string Name, Address;
            public bool IsPermanent;
        }
        class Test
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee();
                Console.WriteLine("Employee Id is : " + e1.Id);
                Console.WriteLine("Employee Name is : " + e1.Name);
                Console.WriteLine("Employee Age is : " + e1.Age);
                Console.WriteLine("Employee Address is : " + e1.Address);
                Console.WriteLine("Employee IsPermanent : " + e1.IsPermanent);
                Console.ReadKey();
            }
        }
    }
}
