using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class Linq
    {
        public static void CallMe()
        {
            Console.WriteLine("find top 3 high frequencey number in descending order");
            int[] a = new int[] { 3, 34, 2, 54, 2, 34, 1, 54, 3, 34, 5, 7, 8, 34, 2 };
            var v = a.GroupBy(x => x).Where(y => y.Count() > 1).Select(x => new { ele = x.Key, cnt = x.Count() }).OrderByDescending(p => p.ele).Take(3);  //to get top 3 high frequency number in descending order
            //var v = a.Distinct();//to get disctinct
            //var v = a.GroupBy(x => x).Select(y => y.First());//to remove duplicates 
            foreach (var i in v)
            {
                Console.WriteLine(i.ele.ToString() + " : " + i.cnt.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------\n");
        }
    }
}
