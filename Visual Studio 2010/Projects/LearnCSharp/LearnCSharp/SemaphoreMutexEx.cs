using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearnCSharp
{
    class SemaphoreMutexEx
    {
        public static void CallMe()
        {
            Class1 obj = new Class1();
            //obj.SemaphoreMethod();
            obj.MutexMethod();
        }


        class Class1
        {
            public void SemaphoreMethod()
            {
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
           
            }
            public void MutexMethod()
            {
                using (var v1 = new Mutex(false, "LearnCSharpMutex"))
                {

                    if (!v1.WaitOne(1000, false))
                    {
                        Console.WriteLine("Already an isntance running..");
                        return;
                    }
                };

            }
        }
    }
}
