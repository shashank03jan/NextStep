using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class ReverseString
    {
        public static void CallMe()
        {
            ReverseString_Rec("How are you");
        }
        public static string ReverseString_Rec(string str)
        {
            if (str.Length <= 1)
                return str;
            else
                return ReverseString_Rec(str.Substring(1)) + str[0];
        }

    }
}
