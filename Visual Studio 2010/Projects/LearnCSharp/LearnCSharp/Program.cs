using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
           
            //ComprareObjects.CallMe();
            //GCReference.Callme();
            //Linq.CallMe();
            //InheritenceExample.CallMe();
            //OverrideExample.CallMe();
            //DelegateExample.CallMe();
            //InheritenceOverloading.CallMe();
            //InheritenceOverriding.CallMe();
            //Parse_TryParse.CallMe();
            //NullComparsion.CallMe();


            ServiceReference1.EmployeeClient obj = new ServiceReference1.EmployeeClient();
            
            Console.WriteLine(obj.GetValue());

            Console.ReadKey();



        }
    }
   
}
