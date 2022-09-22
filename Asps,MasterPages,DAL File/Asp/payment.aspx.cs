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
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }

            loadpage();
        }
        public void loadpage() {

            myDAL objMyDal = new myDAL();
            DataTable DT1 = new DataTable();
            String ST = Session["TotalFare"].ToString();
            String dum = ST.ToString();
            String Totalfare = "Total Fare = " + dum;
            message.InnerHtml = Convert.ToString(Totalfare);
            string T=Session["GeneratedTicketNumber"].ToString();
            String l=Session["Noofseats"].ToString();
            int la = Convert.ToInt32(l);
            int TN = Convert.ToInt32(T);
            int last = (TN + la)-1;
            int found1 = objMyDal.findmanyticket(ref DT1,TN,last);//seting data source for this Grid
                if (found1 == 1)
                {
                    GridView1.DataSource = DT1;
                    GridView1.DataBind(); //bind the data source to this grid

                }
                else
                {
                    message.InnerHtml = Convert.ToString("Error!!!No Ticket Found");
                    Done.Visible = false;
                }
           
            /*int[] n = new int[10];
            DataTable DT1 = new DataTable();
            int found = 0;
            objMyDal.Calculatefareingrid(ref DT1, fo, to, ref found);//seting data source for this Grid
            GridView1.DataSource = DT1;
            GridView1.DataBind(); //bind the data source to this grid
            */

        }
        protected void Directing(object sender, EventArgs e)
        {
            
            myDAL objMyDal = new myDAL();
            String ST = Session["TotalFare"].ToString();
            String dum = ST.ToString();
            String Totalfare = "Total Fare = " + dum;
            String email = Session["Email"].ToString();
            int amount = Convert.ToInt32(ST);
            int f=objMyDal.Payment(email, amount);
            if (f == 1)
            {
                Response.Redirect("Done.aspx");
            }
            else {
                Done.Visible = false;
                message.InnerHtml = Convert.ToString("Sorry!!!!!!You Have inSufficient Balance");
                string T = Session["GeneratedTicketNumber"].ToString();
                int TN = Convert.ToInt32(T);
                objMyDal.deleteticket(TN);
            }
        }
    }
}