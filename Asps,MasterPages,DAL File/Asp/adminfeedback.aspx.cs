using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
using System.Data;
namespace Railways.Asp
{
    public partial class adminfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminEmail"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            DataTable DT1 = new DataTable();
            objMyDal.show_feedback(ref DT1);
            GridView1.DataSource = DT1;
            GridView1.DataBind(); 
        }
    }
}