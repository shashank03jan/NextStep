using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace WcfServiceEmployee
{
    [DataContract]
    public class Employee : IEmployee
    {
        private int _EmployeeId;
        private string _EmployeeName;
        private string _EmployeeAddress;
        private int _EmployeeCode;
        private int _DeparmentId;
        private string _DeparmentName;
        private static int cnt;
        

        [DataMember]
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }

        [DataMember]
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }

        [DataMember]
        public string EmployeeAddress
        {
            get { return _EmployeeAddress; }
            set { _EmployeeAddress = value; }
        }

        [DataMember]
        public int EmployeeCode
        {
            get { return _EmployeeCode; }
            set { _EmployeeCode = value; }
        }

        [DataMember]
        public int DeparmentId
        {
            get { return _DeparmentId; }
            set { _DeparmentId = value; }
        }

        [DataMember]
        public string DeparmentName
        {
            get { return _DeparmentName; }
            set { _DeparmentName = value; }
        }

        public void InsertEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\VisualStudio\\NextStep\\Visual Studio 2010\\Projects\\DatabaseFiles\\Employee.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.InsertEmployee_prc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int empId)
        {
            throw new NotImplementedException();
        }



        public int GetValue()
        {
            cnt = cnt + 1;
            return cnt;
        }


        public void FireAndTrack()
        {
            Console.WriteLine("i am service method and called by client via duplex.");
            Thread.Sleep(5000);
            OperationContext.Current.GetCallbackChannel<IClientCallBackExample>().CallingClient();
        }
    }
}