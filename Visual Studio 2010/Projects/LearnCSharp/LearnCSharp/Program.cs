﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ServiceModel;
using System.Collections;
namespace LearnCSharp
{

    class Program
    {

        static void Main(string[] args)
        {
            LinqToSQLEx.GetEmployee();
            //IQueryable
            ReverseString.CallMe();
            //ComprareObjects.CallMe();
            //GCReference.Callme();
            //Linq.CallMe();
            //InheritenceExample.CallMe();
            //OverrideExample.CallMe();
            DelegateExample.CallMe();
            //InheritenceOverloading.CallMe();
            //InheritenceOverriding.CallMe();
            //Parse_TryParse.CallMe();
            //NullComparsion.CallMe();

            //IAsyncExample.CallMe();

            //OverLoadingWithGeneric.CallMe();
            //Int32 i = new Int32();

            //Dictionary<int, int> d;
            //Array a;
            //ArrayList b;
            //Console.WriteLine((ReverseString_Rec("shashank")));

            //
            //CallWcfServiceExample.CallMe();
            //DelegateBeginInvokeWinForms.CallMe();

            //Event_Delegate.CallMe();
            //LearnCSharpThreading.ThreadingExample.CallMe();
            BackgroundWorkerClassExampleUsingWinForm.CallMe();
            //SemaphoreMutexEx.CallMe();
            //DelegateAnonymousLambadaClosures.CallMe();

            Console.WriteLine("press any key to continue....");
            //Console.ReadKey();
        }

    }

}
