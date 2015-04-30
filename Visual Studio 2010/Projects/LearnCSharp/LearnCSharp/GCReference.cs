using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class GCReference
    {
        public static void Callme()
        {
            MyClassX obj1 = new MyClassX();
            obj1.value = 3;

            MyClassX obj2 = new MyClassX();
            obj2 = obj1;

            Console.WriteLine("If you chang value of variable/property from one instance then it will automatically reflect in another instance");
            obj2.value = 4;
            
            Console.WriteLine(obj1.value);
            Console.WriteLine(obj2.value);

            Console.WriteLine("nullifying one object does not mean instance id GCed. You need to nullify all object, if you want to do so.");
            obj1 = null; // or 
            //obj2 = null;
            Console.WriteLine(obj2.value);

            Console.WriteLine("you can not/NEVER call static method using instance so i am calling it via class name");
            MyClassX.myint = 9;
            Console.WriteLine(MyClassX.myint);
            Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
        }

        class MyClassX
        {
            public int value;
            public static int myint;

        }
    }

}
