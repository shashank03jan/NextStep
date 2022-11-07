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
            //delobj += Classobj.CalledViaDelegate;
            delobj.BeginInvoke(new AsyncCallback(CallbackMethod), null);
            delobj();
        }

        public static void  CallbackMethod(IAsyncResult ir)
        {
            Console.WriteLine("i am call back");
        }
        public void CalledViaDelegate()
        {
            Console.WriteLine("I am a method and i have been called via delegate");
        }
    }

}
//Delegates enable you to call a synchronous method in an asynchronous manner.When you call a delegate synchronously, the Invoke method calls the target method directly on the current thread.
//If the BeginInvoke method is called, the common language runtime (CLR) queues the request and returns immediately to the caller. The target method is called asynchronously on a thread from the thread pool.
//The original thread, which submitted the request, is free to continue executing in parallel with the target method.If a callback method has been specified in the call to the BeginInvoke method, the callback method is called when the target method ends. 
//In the callback method, the EndInvoke method obtains the return value and any input/output or output-only parameters. If no callback method is specified when calling BeginInvoke, EndInvoke can be called from the thread that called BeginInvoke.