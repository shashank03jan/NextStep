using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearnCSharpThreading
{
    class ThreadingExample
    {
        public static void CallMe()
        {
            MyClass obj = new MyClass();
            obj.CreateNewThread();
            Console.WriteLine("this is main thread");

            obj.RunOnThread();

            obj.RunOnThreadPooling();

        }

        class MyClass
        {
            public void CreateNewThread()
            {
                Thread th = new Thread(new ThreadStart(()=>{Console.WriteLine("HI from second thread with ThreadID= "+Thread.CurrentThread.ManagedThreadId.ToString());}),);
                th.Start();
            }

            public void RunOnThread()
            {
                ThreadStart ts = Method;
                Thread th = new Thread(ts);

                th.Start();
            }
            
            public void RunOnThreadPooling()
            {
                //this will create new thread or get an existing thread from threadpool and run method on it. see , we dont need to start like thread.start
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolMethod));

            }
            private void Method()
            {
                Console.WriteLine("starting using thread..");
                Thread.Sleep(3000);
                Console.WriteLine("ending using thread..");

            }
            private void ThreadPoolMethod(object onj)
            {
                Console.WriteLine("starting using threadpool..");
                Thread.Sleep(3000);
                Console.WriteLine("ending using threadpool..");

            }

        }
    }

    
}
