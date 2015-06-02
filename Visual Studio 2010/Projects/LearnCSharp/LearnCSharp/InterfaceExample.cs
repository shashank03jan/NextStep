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
            object obj = new Class1();
            //see this commented code. we can not call method directly using object class.
            //obj.m1();
           ((Class1) obj).m1();
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

            public string EmployeeName
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }
        }

        interface IMyInterface
        {
            //see here , we are defining propery in interface. this MUST be implemented in class which is inheriting this interface
             string EmployeeName { get; set; }
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
