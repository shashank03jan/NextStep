using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class ComprareObjects
    {
        public static void CallMe()
        {
            MyClass2 obj1 = new MyClass2("Shashank", "Delhi");
            MyClass2 obj2 = new MyClass2("Shashank", "Gurgaon");
            MyClass2 obj3 = new MyClass2("Shashank", "Gurgaon");

            if (obj1.Equals(obj2)) Console.WriteLine(true); else Console.WriteLine(false);
            if (obj2.Equals(obj3)) Console.WriteLine(true); else Console.WriteLine(false);


            string s = null;
            string p = null;
            // if we check two null value using equals then null pointer exception
            if (s.Equals(p))
                Console.WriteLine(true);
            else Console.WriteLine(false);


            if (s==p)
                Console.WriteLine(true);
            else Console.WriteLine(false);
        }
       
    }
    class MyClass2
    {
        private string Sname;
        private string address;

        public MyClass2(string name, string add)
        {
            Sname = name;
            address = add;
        }
      
    }
}

