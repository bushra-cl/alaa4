using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace alaa4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["name"].ToString();
            Label2.Text = Session["jop"].ToString();
            Label3.Text = Application["father"].ToString();
            Label4.Text = Application["family"].ToString();
        }
    }
}