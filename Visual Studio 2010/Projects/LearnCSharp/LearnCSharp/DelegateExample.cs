using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    delegate void Mydelegate ();
    class DelegateExample
    {

        public static void CallMe()
        {
            DelegateExample Classobj = new DelegateExample();
            Mydelegate delobj = new Mydelegate(Classobj.CalledViaDelegate);
            delobj += Classobj.CalledViaDelegate;
            delobj.Invoke();
            delobj();
        }

        public void CalledViaDelegate()
        {
            Console.WriteLine("I am a method and i have been called via delegate");
        }
    }

}
