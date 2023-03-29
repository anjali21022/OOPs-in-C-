using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bank1
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                // Validate the value before storing it in the _Amount variable
                if (value < 0)
                {
                    throw new Exception("Please Pass a Positive Value");
                }
                else
                {
                    _Amount = value;
                }
            }
        }
    }
    class Program3
    {
        public static void Main()
        {
            try
            {
                Bank1 bank = new Bank1();
                //We cannot access the _Amount Variable directly
                //bank._Amount = 50; //Compile Time Error
                //Console.WriteLine(bank._Amount); //Compile Time Error
                //Setting Positive Value using public Amount Property
                bank.Amount = 10;
                //Setting the Value using public Amount Property
                Console.WriteLine(bank.Amount);

                //Setting Negative Value
                bank.Amount = -150;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
