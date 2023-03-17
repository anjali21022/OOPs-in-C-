using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Constructors
{
    internal class User_defined_Default_Constructor
    {
        class Employee
        {
            public int Id, Age;
            public string Address, Name;
            public bool IsPermanent;
            //User Defined Default Constructor
            public Employee()
            {
                Id = 101;
                Age = 21;
                Address = "Ghansoli";
                Name = "Anjali";
                IsPermanent = true;
            }
            public void Display()
            {
                Console.WriteLine("Employee Id is:  " + Id);
                Console.WriteLine("Employee Age is:  " + Age);
                Console.WriteLine("Employee Address is:  " + Address);
                Console.WriteLine("Employee Name is:  " + Name);
                Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee();
                e1.Display();
                Console.ReadKey();
            }
        }
    }
}
