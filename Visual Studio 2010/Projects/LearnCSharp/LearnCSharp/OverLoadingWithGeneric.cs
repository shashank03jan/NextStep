using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class OverLoadingWithGeneric
    {
        public static void CallMe()
        {
            class1Base1<int> b = new class1Base1<int>();
            b.method1(100);
        }

         class class1Base1<t>
        {
            public int method1(int i)
            {
                Console.WriteLine(i);
                return i;
            }

            public t method1(t i)
            {
                Console.WriteLine(i);
                return i;
            }
        }
        
    }
}
