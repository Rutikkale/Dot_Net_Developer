using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPost_Back
{
    public partial class IsPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // IsPostBack
            //if (IsPostBack)
            //{
            //    Response.Write(" This is Post Back request !!");
            //}


            // Not IsPostBack
            //if (!IsPostBack)   
            //{
            //    Response.Write(" This is Post Back request !!");
            //}


            //Not IsPostBack for listBox
            if (!IsPostBack)
            {
                AddListBoxItems();
            }


        }

        void AddListBoxItems()
        {
            ListBox1.Items.Add("Item 1");
            ListBox1.Items.Add("Item 2");
            ListBox1.Items.Add("Item 3");
        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
