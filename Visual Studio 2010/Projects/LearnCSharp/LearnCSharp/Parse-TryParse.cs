using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Parse_TryParse
    {
        public static void CallMe()
        {
            //parse can through error if value is not appropriate but tryparse will not
            string str1 = "1";
            string str2 = "string";
            int i = 0;
            int.Parse(str1);
            //int.Parse(str2);
            Console.WriteLine(int.TryParse(str1, out i));
            Console.WriteLine(int.TryParse(str2, out i));
        }
    }
}
