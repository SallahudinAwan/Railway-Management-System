using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
using System.Data;
namespace Railways.Asps
{
    public partial class Calculatefare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            if (Session["Fromstationfare"] != null) {
               //string Tno = Session["Trainno"].ToString();
                string fo = Session["Fromstationfare"].ToString();
                string to = Session["tostationfare"].ToString();
                String S="Calculate Fare ( ";
                S = S + fo;S = S + " - ";
                S = S + to;S = S + " )";
                calfare.Text = S;
                DataTable DT1 = new DataTable();
                int found=0;
                objMyDal.Calculatefareingrid(ref DT1, fo, to,ref found);//seting data source for this Grid
                GridView1.DataSource = DT1;
                GridView1.DataBind(); //bind the data source to this grid
                if (found == 0)
                {
                    message.InnerHtml = Convert.ToString("Error!!!No Train Found");
                }

            }

        }
    }
}