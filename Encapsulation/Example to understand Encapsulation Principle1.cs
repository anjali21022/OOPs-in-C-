using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class bank
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                Console.WriteLine("Pass a Positive Value");
            }
        }
    }
    class Program2
    {
        public static void Main()
        {
            try
            {
                bank bank = new bank();
                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());

                bank.SetAmount(-110);
                Console.WriteLine(bank.GetAmount());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
