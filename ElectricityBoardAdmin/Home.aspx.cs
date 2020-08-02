using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardAdmin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            welcome();
        }

        public void welcome()
        {
            if (Session["name"] == null)
            {
                Response.Redirect("AdminLoginPage.aspx");
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Session["id"] = Convert.ToInt32(TextBox1.Text);
            Response.Redirect("CustomerDetails.aspx");
        }
    }
}