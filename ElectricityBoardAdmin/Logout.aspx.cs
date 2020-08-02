using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricityBoardAdmin
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logout();
        }


        public void logout()
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("AdminLoginPage.aspx");
        }
    }
}