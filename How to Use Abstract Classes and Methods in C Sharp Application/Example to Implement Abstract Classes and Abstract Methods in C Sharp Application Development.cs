using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_Use_Abstract_Classes_and_Methods_in_C_Sharp_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 4);
            Console.WriteLine($"Area of Rectangle : {rectangle.GetArea()}");

            Circle circle = new Circle(12);
            Console.WriteLine($"Area of Circle : {circle.GetArea()}");

            Triangle triangle = new Triangle(15, 12);
            Console.WriteLine($"Area of Triangle : {triangle.GetArea()}");

            Cone cone = new Cone(32, 12);
            Console.WriteLine($"Area of Cone : {cone.GetArea()}");

            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public Rectangle (double Height, double Width)
        {
            this.Height = Height;
            this.Width= Width;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return PI * Radius * Radius;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double GetArea()
        {
            return (Height * Width)/ 2;
        }
    }
    public class Cone : Shape
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
}
