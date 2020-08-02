using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Connection
{
   public class DBHandler
    {
        public SqlConnection GetConnection()
        {
            string con_string = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            //string con_string = "Data Source=LAPTOP-0RNG994B;Initial Catalog=ELectricityBillDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con_string);
            return conn;
        }


    }
}
