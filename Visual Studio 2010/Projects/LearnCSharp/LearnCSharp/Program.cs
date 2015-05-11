using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace LearnCSharp
{

    class Program
    {

        static void Main(string[] args)
        {

            BackgroundWorkerClassExampleUsingWinForm f = new BackgroundWorkerClassExampleUsingWinForm();
            f.ShowDialog();
            return;

            Semaphore s = null;
            try
            {
                s = Semaphore.OpenExisting("SemaphoreExample");
            }
            catch (Exception)
            {

                s = new Semaphore(2, 2, "SemaphoreExample");
            }

            Console.WriteLine("Acquiring");
            s.WaitOne();//as it says it block the the current thread untill current thread is ruuning. so as i have given count 2, even though  it will allow 2 thread to
            //continue to next line. but as soon as 3rd thread trying to acquire lock on underline code. s.waitone will not allow.
            Console.WriteLine("thread acquired");
            Console.ReadLine();
            s.Release();
           
            return;

            using (var v1 = new Mutex(false, "LearnCSharpMutex")) 
            {

                if (!v1.WaitOne(1000,false))
                {
                    Console.WriteLine("Already an isntance running..");
                    return;
                }

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

                //ServiceReference1.EmployeeClient obj = new ServiceReference1.EmployeeClient();
                //Console.WriteLine(obj.GetValue());

                //Event_Delegate.CallMe();
                LearnCSharpThreading.ThreadingExample.CallMe();

                Console.WriteLine("press any key to continue....");
                Console.ReadKey();
            };



        }
    }

}
