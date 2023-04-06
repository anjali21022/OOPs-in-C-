using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsA_and_HasA_Relationship
{
    public class Program
    {
        static void Main()
        {
            Cuboid cuboid = new Cuboid(3, 5, 7);
            Console.WriteLine($"Volume is : {cuboid.Volume()}");
            Console.WriteLine($"Area is : {cuboid.Area()}");
            Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        //Data Members
        public int Length;
        public int Breadth;
        //Member Functions
        public int Area()
        {
            return Length * Breadth;
        }
        public int Perimeter()
        {
            return 2 * (Length + Breadth);
        }
    }
    //Establishing Parent-Child Relationship
    //IS-A Relationship i.e. Cuboid IS-A Rectangle
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
