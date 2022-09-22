using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Railways.DAL;
using System.Web.UI.WebControls;
using System.Data;
namespace Railways.Asps
{
    public partial class BuyTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            Session["Fromstationticket"] = FromStation.Text;
            Session["tostationticket"] = ToStation.Text;
            DataTable DT1 = new DataTable();
            objMyDal.showFromStation(ref DT1);
            FromStation.DataSource = DT1;
            FromStation.DataBind();
            FromStation.DataTextField = "station_name";
            FromStation.DataValueField = "station_name";
            FromStation.DataBind();

            DataTable DT2 = new DataTable();
            objMyDal.showtoStation(ref DT2);
            ToStation.DataSource = DT2;
            ToStation.DataBind();
            ToStation.DataTextField = "station_name";
            ToStation.DataValueField = "station_name";
            ToStation.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Seat.aspx");

        }

    }
}

