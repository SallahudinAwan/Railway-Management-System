using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Railways.Asps
{
    public partial class loginHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
            }
        }
        protected void unloadsession(object sender, EventArgs e)
        {
            Session["Email"] = null;
        }

        }
}