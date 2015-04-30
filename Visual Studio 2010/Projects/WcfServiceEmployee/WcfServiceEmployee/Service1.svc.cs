using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace WcfServiceEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\shekhar\\Documents\\Employee.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd=new SqlCommand("dbo.StoredProcedure1");
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            con.Open();
            cmd.ExecuteNonQuery();
           
        }
    }
}
