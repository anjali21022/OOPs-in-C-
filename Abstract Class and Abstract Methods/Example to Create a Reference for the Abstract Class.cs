using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_and_Abstract_Methodss
{
    internal class Program1
    {
        static void Main()
        {
            //Creating Child class instance
            AbsChild absChild = new AbsChild();

            //Creating abstract class reference pointing to child class object
            AbsParent absparent = absChild;
            //Accessing methods using reference
            absparent.Add(10, 20);
            absparent.Sub(20, 10);
            absparent.Mul(3, 8);
            absparent.Div(50, 15);

            //You cannot call the Mod method using Parent reference as it is a pure child class method
            //absParent.Mod(100, 35);
            Console.ReadKey();
        }
    }
    public abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    public class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
        public void Mod(int x, int y)
        {
            Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
        }
    }
}
