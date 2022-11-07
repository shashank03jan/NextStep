using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace LearnCSharp
{
    class CallWcfServiceExample
    {
        public static void CallMe()
        {

            //ServiceReference1.EmployeeClient obj = new ServiceReference1.EmployeeClient();
            //Console.WriteLine(obj.GetValue());

            
           //IAmCalledByServiceViaCallback v = new IAmCalledByServiceViaCallback();
            //InstanceContext instContext = new InstanceContext(v);
            //ServiceReference1.CallbackExampleDuplexClient obj = new ServiceReference1.CallbackExampleDuplexClient(instContext);
            //obj.FireAndTrack();

            //serviceCall();
        }

        private static void serviceCall()
        {
            //ServiceReference1.EmployeeClient obj = new ServiceReference1.EmployeeClient();
            //ServiceReference1.Employee emp = new ServiceReference1.Employee();
            //emp.EmployeeId = 1;
            //emp.EmployeeName = "shashank";
            //emp.EmployeeCode = 1001;
            //emp.DeparmentName = "Commerce";
            //emp.DeparmentId = 9001;
            //emp.EmployeeAddress = "Gorakhpur";
            //obj.InsertEmployee(emp);

            //Console.WriteLine(obj.GetValue());
            //Console.ReadKey();
        }
        
    }
    //class IAmCalledByServiceViaCallback : ServiceReference1.ICallbackExampleDuplex
    //{
    //    public void CallingClient()
    //    {
    //        Console.WriteLine("i am called by service via duplex contrat after sservice executed its method");
    //    }

      
    //}
}
