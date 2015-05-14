using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{

    class DelegateAnonymousLambadaClosures
    {
        delegate int d(int i);
        public static void CallMe()
        {
            AnonymousEx();
            
        }

        private static void LambadaEx()
        {
            d x = (int j) => j = j + 1; //without curly braces lambada expression
            d y = (int p) => { return p++; }; //with curly bracess lambada expression and return keyword
            int k = x(3);
            Console.WriteLine(x(3));
        }
        private static void AnonymousEx()
        {
            int m = 7;
            Action<int> act = delegate(int j) { j++; }; //this is anonymous 
            Action act2 = ()=>m++;
            act2();
            act2();

            Func<int, int> fun = (int h) => { m = h + m + 5; return m; };//this is lambada as well as closures
            Console.WriteLine(fun(3));
            Console.WriteLine(fun(3));
            Func<int, int> fun2 = i => i++; // here it automatically add return statement as well as consider i as int
            Func<int, int> fun3 = i => { return i++; };//whenever u use brace , we need to use return keyword. just think in the direction that u are defining a method without name.
            // same as above but see declaring type also. 
            Func<int, int> fun4 = (int i) => { return i++; };
            //Func<int, string, int> fun5 = i => { return i++; };// see this code will not work because it is accepting one more arg to function
            Func<int, string, int> fun5 = ( i,s) => { return i++; };//look at here, it automatically got that first is int and second is string. look below
            Func<int, string, int> fun6 = (int i, string s) => { return i++; };
        }
        
    }
}
