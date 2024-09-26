using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomeValidatorAnotherExp
{
    public partial class CusotmeValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UxSubmit_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scriptKey", "<script>alert('You From has been submited succesfully!');</script>");
        }

        // Server-side custom validation for Gender
        protected void ValidateGender(object source, ServerValidateEventArgs args)
        {
            // Ensure at least one radio button is selected (Male or Female)
            if (MaleRadioButton.Checked || FemaleRadioButton.Checked)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        
    }
}