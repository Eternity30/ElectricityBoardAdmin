using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using Connection;

namespace ElectricityBoardAdmin
{
    public class ElectricityBoard
    {
        //Adding bill to the DataBase
       public void AddBill(ElectricityBill ebill)
        {

            DBHandler dbh = new DBHandler();
            SqlConnection con = dbh.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into  ELectricityBill values('" + ebill.ConsumerNumber + "','" +
                ebill.ConsumerName + "'," + ebill.UnitsConsumed + "," + ebill.BillAmount + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //Calculating the bill
       public void CalculateBill(ElectricityBill ebill)
        {
            int eb = ebill.UnitsConsumed;
            double amount = 0;
            if(eb<=100)
            {
                amount = 0;
            }
            else if(eb>100 && eb<=300)
            {
                amount = (eb - 100) * 1.50;
            }
            else if(eb>300 && eb<=600)
            {
                amount = (200 * 1.50) + (eb-300) * 3.5;
            }
            else if(eb>600 && eb<=1000)
            {
                amount = (200 * 1.50) + (300 * 3.5) + (eb-600) * 5.5;
            }
            else
            {
                amount = (200 * 1.50) + (300 * 3.5) + (400 * 5.5) + (eb - 1000) * 7.5;
            }
            ebill.BillAmount = amount;
        }

        //Generating n bills
       public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> EB = new List<ElectricityBill>();
             
            DBHandler dbh = new DBHandler();
            SqlConnection conn = dbh.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP(" + num + ") * FROM ElectricityBill Order By id DESC", conn);
            //SqlCommand cmd = new SqlCommand("select * from ElectricityBill where id not in (select top((select count(*) from ElectricityBill) - " + num + ")id from ElectricityBill)", conn);
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            //for (int i = 0; i < num; i++)
            //{
                while (reader.Read())
                {
                //EB[i].ConsumerNumber = reader.GetString(1);
                //EB[i].ConsumerName = reader.GetString(2);
                //EB[i].UnitsConsumed = reader.GetInt32(3);
                //EB[i].BillAmount = reader.GetInt32(4);
                ElectricityBill eb = new ElectricityBill(reader.GetString(2), reader.GetString(1), reader.GetInt32(3),reader.GetDouble(4));
                 //eb.ConsumerName = reader.GetString(2);
                 //   eb.ConsumerNumber = reader.GetString(1);
                 //   eb.UnitsConsumed = reader.GetInt32(3);
                 //   eb.BillAmount = reader.GetInt32(4);
                    EB.Add(eb);
                 }
                //i++;
                //reader.NextResult();
            //}
            return EB;
        }

    }
}