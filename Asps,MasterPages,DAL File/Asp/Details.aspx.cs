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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            DataTable DT1 = new DataTable();
            String TN = Session["TicketNumberSearch"].ToString();
            int ticketnumber = Convert.ToInt32(TN);
            int found=objMyDal.findticket(ref DT1,ticketnumber);//seting data source for this Grid
            if (found == 1)
            {
                GridView1.DataSource = DT1;
                GridView1.DataBind(); //bind the data source to this grid

            }
            else {
                message.InnerHtml = Convert.ToString("Error!!!No Ticket Found");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("TicketDetails.aspx");

        }
    }
}