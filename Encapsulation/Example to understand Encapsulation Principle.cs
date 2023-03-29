using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Banks
    {
        public int Amount;
    }
    class Program1
    {
        public static void Main()
        {
            Banks bank = new Banks();
            //We can access the Amount Variable directly

            //Setting positive amount
            bank.Amount = 50;
            Console.WriteLine(bank.Amount);

            //Setting negative amount
            bank.Amount = -50;
            Console.WriteLine(bank.Amount);
            Console.ReadKey();
        }
    }
}
