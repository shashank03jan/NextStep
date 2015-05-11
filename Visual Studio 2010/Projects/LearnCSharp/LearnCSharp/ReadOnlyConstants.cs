using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp3
{
    class ReadOnlyConstants
    {
        //you can not assign readonly twice
        public static void CallMe()
        {
            MyClass2 obj = new MyClass2();
            //obj.i = 4;
        }
    }
    class MyClass2
    {
        readonly public int i;


        public MyClass2()
        {
            i = 5;
        }

    }
}
