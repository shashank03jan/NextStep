using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WcfServiceLibraryEmployee
{
    [DataContract]
    public class Employee 
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

    



    }
}
