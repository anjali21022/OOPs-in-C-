using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization_and_Specialization
{
    internal class Specialization
    {
        static void Main()
        {
            Cuboid obj = new Cuboid(7, 2, 5);
            Console.WriteLine($"Area is {obj.Area()}");
            Console.WriteLine($"Perimeter is {obj.Perimeter()}");
            Console.WriteLine($"Volume is {obj.Volume()}");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        public int Length;
        public int Breadth;
        public int Area()
        {
            return Length * Breadth;
        }
        public int Perimeter()
        {
            return 2 * (Length + Breadth);
        }
    }
    class Cuboid : Rectangle
    {
        public int Height;
        public Cuboid(int l, int b, int h)
        {
            Length = l;
            Breadth = b;
            Height = h;
        }
        public int Volume()
        {
            return Length * Breadth * Height;
        }
    }
}
