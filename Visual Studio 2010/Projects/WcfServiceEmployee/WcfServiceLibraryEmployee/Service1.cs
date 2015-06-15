using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfServiceLibraryEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private static int cnt;
        public void InsertEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\VisualStudio\\NextStep\\Visual Studio 2010\\Projects\\DatabaseFiles\\Employee.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("dbo.InsertEmployee_prc", con);
            cmd.Parameters.Add(new SqlParameter("@EmployeeName", emp.EmployeeName));
            cmd.Parameters.Add(new SqlParameter("@EmployeeAddress", emp.EmployeeAddress));
            cmd.Parameters.Add(new SqlParameter("@EmployeeCode", emp.EmployeeCode));
            cmd.Parameters.Add(new SqlParameter("@Departmentid", emp.DeparmentId));
            cmd.Parameters.Add(new SqlParameter("@DeparmentName", emp.DeparmentName));

            //cmd.Parameters.Add(new SqlParameter( emp.EmployeeName);
            //cmd.Parameters.Add(emp.EmployeeAddress);
            //cmd.Parameters.Add(emp.EmployeeCode);
            //cmd.Parameters.Add(emp.DeparmentId);
            //cmd.Parameters.Add(emp.DeparmentName);

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


    }
}
