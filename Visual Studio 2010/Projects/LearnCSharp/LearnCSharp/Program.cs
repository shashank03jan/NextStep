using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ServiceModel;
namespace LearnCSharp
{

    class Program
    {

        static void Main(string[] args)
        {

            //IQueryable

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


            CallWcfServiceExample.CallMe();


            //Event_Delegate.CallMe();
            //LearnCSharpThreading.ThreadingExample.CallMe();
            //BackgroundWorkerClassExampleUsingWinForm.CallMe();
            //SemaphoreMutexEx.CallMe();
            //DelegateAnonymousLambadaClosures.CallMe();

            Console.WriteLine("press any key to continue....");
            Console.ReadKey();



        }
    }
   


}
