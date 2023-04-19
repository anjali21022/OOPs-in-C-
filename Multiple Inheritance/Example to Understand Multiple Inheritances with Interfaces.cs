using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    class Multiple_Inheritances_with_Interfaces
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Console.ReadKey();
        }
    }
    public interface Interface1
    {
        void Test();
    }
    public interface Interface2
    {
        void Test();
    }
    public class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Test Method is implemented in Child Class");
        }
    }
}
