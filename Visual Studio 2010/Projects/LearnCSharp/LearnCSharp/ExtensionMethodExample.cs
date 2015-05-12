using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp2
{
    class ExtensionMethodExample
    {
        public static void CallMe()
        {
            //see here
            MyClass obj = new MyClass();
            obj.CalculateSalary();
            obj.CalCulateTax();
        }
       
    }
    class MyClass
    {

        public void CalculateSalary()
        {
            Console.WriteLine("this is my salary");
        }
    }
    static class MyExtensionMethod
    {
        public static void CalCulateTax(this MyClass cl)
        {
            Console.WriteLine("this is my tax and called from MyClass instance");
        }
    }
    
}
