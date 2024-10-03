using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_State
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Write("Welcome " + Session["User"].ToString());
            }
            else
            {
                Response.Redirect("Webform1.aspx");
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            if(Session["User"] != null)
            {
                Session["User"] = null;
                Response.Redirect("Webform1.aspx");
            }
        }
    }
}