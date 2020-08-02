using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using Connection;
using System.Data;


namespace ElectricityBoardAdmin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcome();
            if(Convert.ToBoolean(Session["f"]))
            {
                    Label6.Visible = true;
           
            }
            else
            {
                Label6.Visible = false;
            }
        }

        protected void Submit_Click(object sender,EventArgs e)
        {
            Page.Validate();
            if(!Page.IsValid)
            {
                Label6.Visible = false;

            }
            bool u = true;
            bool f = true;
            string error = "";
            BillValidator bv = new BillValidator();
            ElectricityBill ee = new ElectricityBill();
            ee.UnitsConsumed = Int32.Parse(units_consumed.Text);
            error = bv.ValidateUnitsConsumed(ee.UnitsConsumed);
            ee.ConsumerName = customer_name.Text;
            try
            {
                ee.ConsumerNumber = customer_num.Text;
            }

            catch (FormatException fe)
            {
                exception.Text = "Consumer Number Format Is Wrong";
                exception.Visible = true;
                Label6.Visible = false;
                f = false;
            }
            if (error != "")
                {
                Label4.Text = error;
                Label4.Visible = true;
                units_consumed.Text = null;
                u = false;
                
            }
            else
            {
                Label6.Visible = false;
                Label4.Visible = false;
                u = true;
            }

            if(!Page.IsValid)
            {
                Label6.Visible = false;
            }
            int n = Convert.ToInt32(Session["id"]);
            bool i = select(customer_num.Text);

            if(f && u && i)
            {
                if (n > 1)
                {
                    
                    Session["id"] = Convert.ToInt32(Session["id"]) - 1;
                    Session["f"] = true;
                    exception.Visible = false;
                    ElectricityBoard eb = new ElectricityBoard();
                    eb.CalculateBill(ee);
                    eb.AddBill(ee);
                    units_consumed.Text = null;
                    customer_name.Text = null;
                    customer_num.Text = null;
                    Label4.Visible = false;
                    Label8.Visible = false;
                    Label6.Visible = false;
                    Response.Redirect("CustomerDetails.aspx");
                }
                else
                {
                    exception.Visible = false;
                    ElectricityBoard eb = new ElectricityBoard();
                    eb.CalculateBill(ee);
                    eb.AddBill(ee);
                    units_consumed.Text = null;
                    customer_name.Text = null;
                    customer_num.Text = null;
                    Label4.Visible = false;
                    Label8.Visible = false;
                    Response.Redirect("Retrieved.aspx");

                }
            }
            else
            {
                Label6.Visible = false;
            }
            if(!i)
            {
                Label8.Visible = true;
                Label6.Visible = false;
            }

        }


        public void welcome()
        {
            if (Session["name"] != null)
            {
                Label5.Text = "WELCOME " + Session["name"];
                Label6.Visible = false;
                exception.Visible = false;
                Label4.Visible = false;
                Label8.Visible = false;
            }
            else
            {
                Response.Redirect("AdminLoginPage.aspx");
                customer_num.Text = null;
            }

            
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Retrieved.aspx");
        }

        public bool select(string num)
        {
            bool i = false;

            DBHandler dB = new DBHandler();
            SqlConnection conn= dB.GetConnection();
            SqlCommand cmd = new SqlCommand("select * from ElectricityBill where consumer_number='"+num+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sd.SelectCommand = cmd;
            sd.Fill(ds, "ElectricityBill");
            if (ds.Tables[0].Rows.Count > 0)
            {
                i = false;
            }
            else
            {
                i = true;
            }
                return i;
        }

        //public void loop_n()
        //{
        //    int n = Convert.ToInt32(Session["id"]);
        //    if (n >= 1)
        //    {
               
        //        Session["id"] = Convert.ToInt32(Session["id"]) - 1;

        //    }
        //    else
        //    {

        //        Response.Redirect("Retrieved.aspx");
        //    }
        //}

        public void reset()
        {
            units_consumed.Text = null;
            customer_name.Text = null;
            customer_num.Text = null;
            Label6.Visible = false;
            exception.Visible = false;
            Label4.Visible = false;
            Label8.Visible = false;
        }


    }
    }