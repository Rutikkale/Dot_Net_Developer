using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_State
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxSubmitButton_Click(object sender, EventArgs e)
        {
            //Session.Add("User", UserTextBox.Text);
            Session["User"] = UserTextBox.Text;
            Response.Redirect("webform2.aspx");
        }
    }
}