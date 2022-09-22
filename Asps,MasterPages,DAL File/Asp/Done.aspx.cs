using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class Done : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
     }
    protected void HomeD(object sender, EventArgs e)
        {
            Response.Redirect("loginHomePage.aspx");
        }
    }
}