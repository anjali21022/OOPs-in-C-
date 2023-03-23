﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Privatee_Constructors
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Singleton Constructor Executed {counter} Time");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine($"Some Method Called : {Message}");            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromPlace1 = Singleton.GetSingletonInstance();
            fromPlace1.SomeMethod("From Place 1");
            Singleton fromPlace2 = Singleton.GetSingletonInstance();
            fromPlace2.SomeMethod("From Place 2");
            Console.ReadKey();
        }
    }
}
