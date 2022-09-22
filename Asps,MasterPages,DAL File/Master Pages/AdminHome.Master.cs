using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Railways.Master_Pages
{
    public partial class Adminlogin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminEmail"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }

        }
        protected void unload_admin(object sender, EventArgs e)
        {
            Session["AdminEmail"] = null;
        }
    }
}