using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization_and_Specialization
{
    internal class Generalization
    {
        static void Main()
        {
            Innova obj1 = new Innova();
            obj1.Start();
            obj1.Stop();

            BMW obj2 = new BMW();
            obj2.Start();
            obj2.Stop();

            Console.ReadKey();
        }
    }
    interface Car
    {
        void Start();
        void Stop();
    }
    public class Innova : Car
    {
        public void Start()
        {
            Console.WriteLine("Innova start");
        }
        public void Stop()
        {
            Console.WriteLine("Innova stop");
        }
    }
    public class BMW : Car
    {
        public void Start()
        {
            Console.WriteLine("BMW start");
        }
        public void Stop()
        {
            Console.WriteLine("BMW stop");
        }
    }
}
