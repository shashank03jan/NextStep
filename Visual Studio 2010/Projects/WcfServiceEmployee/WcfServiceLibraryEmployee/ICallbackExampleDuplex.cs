using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Threading;
using System.Runtime.Serialization;

namespace WcfServiceLibraryEmployee
{
    [ServiceContract(CallbackContract = typeof(IClientCallBackExample))]
    public interface ICallbackExampleDuplex
    {
        [OperationContract(IsOneWay = true)]
        void FireAndTrack();
    }

      
    public class ImplementICallbackExampleDuplex : ICallbackExampleDuplex
    {
        public void FireAndTrack()
        {
            Console.WriteLine("i am service method and called by client via duplex.");
            Thread.Sleep(5000);
            OperationContext.Current.GetCallbackChannel<IClientCallBackExample>().CallingClient();
        }
    }


    [ServiceContract]
    public interface IClientCallBackExample
    {
        [OperationContract(IsOneWay = true)]
        void CallingClient();
    }
}