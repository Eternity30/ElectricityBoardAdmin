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
    public partial class Retrieved : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcome();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //DBHandler dbh = new DBHandler();
            //SqlConnection conn = dbh.GetConnection();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT TOP("+ Convert.ToInt32(Retrieve_n.Text)+") * FROM ElectricityBill Order By id DESC",conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            ElectricityBoard elbo = new ElectricityBoard();

            GridView1.DataSource = elbo.Generate_N_BillDetails(Convert.ToInt32(Retrieve_n.Text.ToString())) ;
            //int n = Convert.ToInt32(Retrieve_n.Text);

            GridView1.DataBind();
            //for (int i=0;i<n;i++)
            //{
                
                //Response.Write(EB[i].ConsumerNumber + EB[i].ConsumerName + EB[i].UnitsConsumed + EB[i].BillAmount);

            //}
            
            //foreach(ElectricityBill ee in EB)
            //{
            //    Response.Write(ee.ConsumerNumber + ee.ConsumerName + ee.UnitsConsumed + ee.BillAmount);
            //}
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