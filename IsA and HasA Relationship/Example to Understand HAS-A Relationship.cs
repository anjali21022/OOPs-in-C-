using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsA_and_HasA_Relationship
{
    public class Program1
    {
        static void Main()
        {
            Address address = new Address("Pragati Nagar", "Ghansoli", "Maharashtra");
            Employee employee = new Employee(1001, "Anjali", address);
            employee.Display();
            Console.ReadKey();
        }
    }
    class Address
    {
        public string AddressLine, City, State;
        public Address(string addressLine, string city, string state)
        {
            AddressLine = addressLine;
            City = city;
            State = state;
        }
    }
    class Employee
    {
        //Using Address in Employee class
        //Establishing Has-A relationship i.e. Employee HAS-A Address   
        public Address address;
        public int Id;
        public string Name;
        public Employee(int id, string name, Address adrs)
        {
            Id = id;
            Name = name;
            address = adrs;
        }
        public void Display()
        {
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"AddressLine: {address.AddressLine}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"State: {address.State}");
        }
    }
}
