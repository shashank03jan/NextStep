using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class InterfaceExample
    {
        public static void CallMe()
        {
            Console.WriteLine("Interface Example");
            IMyInterface obj11 = new Class1();
            Class1 obj21 = new Class1();
            Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
        }

        class Class1 : IMyInterface
        {

            public void m1()
            {
                Console.WriteLine("m1");
            }
            public void m2()
            {
                Console.WriteLine("m2");
            }
        }

        interface IMyInterface
        {
            void m1();
        }
    }
    interface IEmployee
    {
        void m1();
    }
    class e1 : IEmployee
    {
        public void m1()
        {
            throw new NotImplementedException();
        }
    }
    class e2 : e1, IEmployee
    {
        public void m1()
        {
            throw new NotImplementedException();
        }
    }

   
}
