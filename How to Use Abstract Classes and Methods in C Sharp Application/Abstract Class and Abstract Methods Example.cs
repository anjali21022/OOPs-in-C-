using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_to_Use_Abstract_Classes_and_Methods_in_C_Sharp_Application
{
    public abstract class Plan
    {
        protected abstract double getRate();
        public void Calculation(int units)
        {
            double rate = getRate();
            Console.WriteLine($"Bill Amount For {units} Units is: Rs. {rate * units}");
        }
    }
    class CommercialPlan : Plan
    {
        protected override double getRate()
        {
            return 5.00;
        }
    }
    class DomesticlPlan : Plan
    {
        protected override double getRate()
        {
            return 2.50;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("Commercial Plan");
            p = new CommercialPlan();
            p.Calculation(10);
            Console.WriteLine("Domesticl Plan");
            p = new DomesticlPlan();
            p.Calculation(150);
            Console.ReadKey();
        }
    }
}
