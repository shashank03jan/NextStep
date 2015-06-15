using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFServiceSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //WcfServiceEmployee
            ServiceHost host = new ServiceHost(typeof(WcfServiceEmployee.Employee));
            host.Open();
            Console.WriteLine("WcfServiceEmployee service started...");

            //WcfServiceLibraryEmployee
            //ServiceHost host2 = new ServiceHost(typeof(WcfServiceLibraryEmployee.Service1));
            //host2.Open();
            //Console.WriteLine("WcfServiceLibraryEmployee service started...");




            Console.ReadKey();

        }
    }
}
