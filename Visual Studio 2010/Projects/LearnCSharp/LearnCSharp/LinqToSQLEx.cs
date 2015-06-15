using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnCSharp
{
    class LinqToSQLEx
    {

        public static void CallMe()
        {
            GetEmployee();
        }
        public static void GetEmployee()
        {
            LinqToSQLExampleDataContext myDB = new LinqToSQLExampleDataContext();
            var userResults = from u in myDB.Employees
                              select u.EmployeeName;
            foreach (string str in userResults)
            {
                Console.WriteLine(str);
            }
            //return Enumerable.Count(userResults) > 0;
        }
    }
}
