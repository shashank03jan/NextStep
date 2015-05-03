using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
namespace LearnCSharp
{
    class NullComparsion : System.Object
    {
        
        // though dt has beed assigned default value but default value can be check with null
        static DateTime dt;
        public static void CallMe()
        {
            if(dt==null)
            Console.WriteLine(dt.ToString());
        }
    }
}
