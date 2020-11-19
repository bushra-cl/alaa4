using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace alaa4
{
    public partial class c_q : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string strname = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie coco = new HttpCookie("login");
            coco.Values.Add("name", "bushra");
            coco.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(coco);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
         
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            if (Request.QueryString["name"] != null)
            {
                string str = Request.QueryString["name"];
                Response.Write("hello" + str);
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("c q.aspx?name=bushra");
        }
    }
}