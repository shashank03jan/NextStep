using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class StaticConcept
    {
        public static void CallMe()
        {
            StaticConcept.method1();
            StaticConcept.method1(1);
            StaticConcept.method1("shashank");
        }

        //static method can be private.
        //see overloading static method. Though it looks like we are overloading it but actually it is not.
        //because overloading works on instance 
        private static void method1()
        {
        }

        public static void method1(int i)
        {
        }
        public static void method1(string str)
        {
        }

        //see inherting is not possible, both as derive as well as base static class
        //public static class x : y { }
        //public class y { }

        //public  class x1 : y1 { }
        //public static class y1 { }
    }
   static class StaticConcept1
    {
       

        //static method can be private.
        //see overloading static method. Though it looks like we are overloading it but actually it is not.
        //because overloading works on instance 
        private static void method1()
        {
        }

        public static void method1(int i)
        {
        }
        public static void method1(string str)
        {
        }

        //see inherting is not possible, both as derive as well as base static class
        //public static class x : y { }
        //public class y { }

        //public  class x1 : y1 { }
        //public static class y1 { }
    }
}
