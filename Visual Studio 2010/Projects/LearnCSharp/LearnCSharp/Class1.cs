using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Class1
    {
       public delegate int del(int k);
        public static void CallMe()
        {
            cl3 obj3 = new cl3();
            del p = obj3.CallMe2();
            Console.WriteLine( p.Invoke(5));//11
            Console.WriteLine(p.Invoke(7));//13
            Console.WriteLine(p.Invoke(9));//15
        }

        

        class cl3
        {
            public del CallMe2()
            {
                int i = 5;
                del d = (int j) =>
                {
                    i = i + 1; return i + j;
                };

                return d;
            }

            
        }


    }
}
