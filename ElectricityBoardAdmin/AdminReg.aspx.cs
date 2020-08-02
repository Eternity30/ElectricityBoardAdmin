using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Connection;

namespace ElectricityBoardAdmin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcome();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            DBHandler dbh = new DBHandler();
            SqlConnection conn = dbh.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into AdminRegistration values('"+Username.Text+"','"+email.Text+"','"+password.Text+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void welcome()
        {
            if (Session["name"] == null)
            {
                Response.Redirect("AdminLoginPage.aspx");
            }
        }

       
    }
}