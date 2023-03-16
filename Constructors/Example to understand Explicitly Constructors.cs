using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Explicitly_Constructors
    {
        static void Main(string[] args)
        {
            ExplicitConstructor obj = new ExplicitConstructor();
            Console.ReadKey();
        }
    }
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor is Called");
        }
    }
}
