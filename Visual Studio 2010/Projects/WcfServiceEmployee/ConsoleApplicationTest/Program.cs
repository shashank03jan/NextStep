using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.EmployeeClient obj = new ServiceReference1.EmployeeClient();
            ServiceReference1.Employee emp = new ServiceReference1.Employee();
            emp.EmployeeId = 1;
            emp.EmployeeName = "shashank";
            emp.EmployeeCode = 1001;
            emp.DeparmentName = "Commerce";
            emp.DeparmentId = 9001;
            emp.EmployeeAddress = "Gorakhpur";
            obj.InsertEmployee(emp);

            Console.WriteLine(obj.GetValue());
            Console.ReadKey();

        }
    }
}
