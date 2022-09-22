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
    public partial class TicketDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["TicketNumberSearch"] = SelTrain.Text;
            Response.Redirect("Details.aspx");

        }
        protected void deletetrain(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String S = delticket.Text;
            int ticket = Convert.ToInt32(S);
            int f = 0;
            objMyDal.deleteticketbyid(ticket,ref f);
            if (f == 0)
            {
                message.InnerHtml = Convert.ToString("Error!!!No Ticket Found");
            }
            else {
                message.InnerHtml = Convert.ToString("Ticket Removed Successfully and Refunded as Well!!");
            }
        }
    }
}