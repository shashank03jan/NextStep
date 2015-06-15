using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class InstanceNullifyQuestion
    {
        public static void CallMe()
        {
            example e = new example();
            Console.WriteLine(e.i);
            see(e);
            Console.WriteLine(e.i);
        }

        public class example
        {
            public int i = 1;
        }
        public static void see(example e1)
        {
            e1.i = 10;
            e1 = null;
        }
    }
}
