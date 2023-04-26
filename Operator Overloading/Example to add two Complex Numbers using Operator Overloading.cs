using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program1
    {
        static void Main(string[] args)
        {
            Complexx c1 = new Complexx(9, 25);
            c1.Display();
            Complexx c2 = new Complexx(23, 14);
            c2.Display();
            Complexx c3 = c1 + c2;
            c3.Display();

            Console.ReadKey();
        }
    }
    public class Complexx
    {
        private int real;
        private int img;
        public Complexx(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        public static Complexx operator +(Complexx c1, Complexx c2)
        {
            Complexx temp = new Complexx();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
}
