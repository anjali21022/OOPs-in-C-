using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Inheritance
{
    internal class Multiple_Inheritance
    {
        static void Main()
        {
            SmartPhone obj = new SmartPhone(); ;
            obj.GetPhoneModel();
            //uncomment during execution
            //obj.GetCameraDetails();
            obj.GetDetails();
        }
    }
    //Parent Class 1
    class Phone
    {
        public void GetPhoneModel()
        {
            Console.WriteLine(" Samsung F23 Phone");
        }
    }
    //Parent Class 2
    class Camera
    {
        public void GetCameraDetails()
        {
            Console.WriteLine("24 Mega Pixel Camera");
        }
    }
    //Child Class derived from more than one Parent class
    class SmartPhone : Phone//, Camera
    {
        public void GetDetails()
        {
            Console.WriteLine("It,s a Samsung Smart Phone");
        }
    }
}
