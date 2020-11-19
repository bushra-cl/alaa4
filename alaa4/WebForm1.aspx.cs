using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace alaa4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["jop"] = TextBox2.Text;
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Application["father"] = TextBox3.Text;
            Application["family"] = TextBox4.Text;
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}