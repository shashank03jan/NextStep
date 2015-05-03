using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WcfServiceEmployee
{
    [ServiceContract]
    interface IEmployee
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
    }
}
