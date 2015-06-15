using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InsertEmployee(Employee emp);

        [OperationContract]
        List<Employee> GetEmployees();

        [OperationContract]
        void UpdateEmployee(Employee emp);

        [OperationContract]
        void DeleteEmployee(int empId);

        [OperationContract]
        int GetValue();

        // TODO: Add your service operations here
    }

}
