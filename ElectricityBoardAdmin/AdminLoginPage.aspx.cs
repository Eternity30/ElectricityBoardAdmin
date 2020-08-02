using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using Connection;
using System.Data;

namespace ElectricityBoardAdmin
{
    public partial class AdminLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["f"] = false;
            Session["id"] = 1;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            DBHandler dbh = new DBHandler();
            SqlConnection conn = dbh.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sd = new SqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "Select * from AdminRegistration where username='"+Username.Text+"' and pass='"+Password.Text+"'";
            cmd.Connection = conn;
            sd.SelectCommand = cmd;
            sd.Fill(ds, "AdminRegistration");
            if(ds.Tables[0].Rows.Count > 0)
            {
                Session["name"] = Username.Text;
                Response.Redirect("Home.aspx");
                Session.RemoveAll();
            }
            else
            {
                Labele.Visible = true;
            }
                    





            //if(Username.Text == "Tarun" && Password.Text == "root" )
            //{
            //    Response.Redirect("CustomerDetails.aspx");
            //}

            //if(Username.Text != "Tarun" && Password.Text != "root")
            //{
            //    Labele.Visible = true;
            //}




        }
    }
}