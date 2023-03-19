using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_We_Need_Constructors
{
    internal class Parameterized_Constructor_Real_time_Example
    {
        class Employee
        {
            public int Id, Age;
            public string Name, Address;
            public bool IsPermanent;

            public Employee(int id, int age, string name, string address, bool isPermanent)
            {
                Id = id;
                Age = age;
                Name = name;
                Address = address;
                IsPermanent = isPermanent;
            }

            public void Display()
            {
                Console.WriteLine("Employee Id is :" + Id);
                Console.WriteLine("Employee Name is :" + Name);
                Console.WriteLine("Employee Age is :" + Age);
                Console.WriteLine("Employee Address is :" + Address);
                Console.WriteLine("Employee IsPermanent :" + IsPermanent);                
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee(101, 21, "Anjali", "Ghansoli", true);
                e1.Display();
                Console.WriteLine();
                Employee e2 = new Employee(102, 24, "Ajay", "Ghansoli", false);
                e2.Display();
                Console.ReadKey();
            }
        }
    }
}
