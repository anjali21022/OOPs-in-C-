using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritancee
{
    class How_to_Implement_Each_Interfaces_Method_Separately
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            //You cannot call the Show method using obj
            //obj.Show();
            //Using Interface Reference call the Show method
            Interface1 i1 = obj;
            i1.Show();
            //Typecase the object to interface type and call the show method
            ((Interface2)obj).Show();
            Console.ReadKey();
        }
    }
    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }
    public class MultipleInheritanceTest : Interface1, Interface2
    {
        //Normal Implementation
        public void Test()
        {
            Console.WriteLine("Test Method is Implemented in Child Class");
        }
        //Explicit Interface Implementation
        void Interface1.Show()
        {
            Console.WriteLine("Interface1 Show Method is Implemented in Child Class");
        }
        //Explicit Interface Implementation
        void Interface2.Show()
        {
            Console.WriteLine("Interface2 Show Method is Implemented in Child Class");
        }
    }
}
