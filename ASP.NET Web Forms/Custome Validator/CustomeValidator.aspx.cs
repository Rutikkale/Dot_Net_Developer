using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Custome_Validator
{
    public partial class CustomeValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EvenNumberCutomValidator(object source, ServerValidateEventArgs args)
        {
            int value = int.Parse(args.Value);

            if (value % 2 == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scriptkey", "<Script> alert('Your form has been Submitted successfully!!');</Script>");
        }
    }
}