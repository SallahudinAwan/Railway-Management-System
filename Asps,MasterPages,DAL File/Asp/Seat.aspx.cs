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
    public partial class Seat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            string fo = Session["Fromstationticket"].ToString();
            string to = Session["tostationticket"].ToString();
            DataTable DT1 = new DataTable();
            int found = 0;
            objMyDal.Calculatefareingrid(ref DT1, fo, to, ref found);//seting data source for this Grid
            GridView1.DataSource = DT1;
            GridView1.DataBind(); //bind the data source to this grid
        }

        protected void ReDirect(object sender, EventArgs e)
        {
            Session["SelectedTrainNumber"] = RefTrain.Text;
            Session["SelectedNumberofSeats"] = NoOfSeats.Text;
            myDAL objMyDal = new myDAL();
            string fo = Session["Fromstationticket"].ToString();
            string to = Session["tostationticket"].ToString();
            string ST = Session["SelectedTrainNumber"].ToString();
            String email = Session["Email"].ToString();
            int TrainNum = Convert.ToInt32(ST);
            string TS = Session["SelectedNumberofSeats"].ToString();
            int noofseats = Convert.ToInt32(TS);
            Session["Noofseats"] = noofseats.ToString();
            int fare = 0, trip_id = 0; DateTime DT = new DateTime(2019, 05, 09, 9, 15, 0); int found = 0;
            objMyDal.gettripinformation(fo, to, TrainNum, ref fare, ref trip_id, ref DT, ref found);
            Session["TotalFare"] = (fare * noofseats).ToString();
            if (found == 1)
            {
                int TN = 0,tn=0;
                for (int i = 0; i < noofseats; i++)
                {
                    objMyDal.generateticket(email, TrainNum, trip_id, DT, ref TN);
                    if (i == 0) { tn = TN;}
                }
                Session["GeneratedTicketNumber"] = tn.ToString();
                int tF = fare * noofseats;
                Session["TotalFare"] = tF.ToString() ;
            }
            else
            {
                message.InnerHtml = Convert.ToString("Sorry!!!!!!Seats Are Full");
            }
            
            Response.Redirect("payment.aspx");
        }

    }
}