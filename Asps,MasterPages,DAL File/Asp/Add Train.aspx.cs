using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Railways.DAL;
namespace Railways.Asps
{
    public partial class Add_Train : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminEmail"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }

        }
        protected void AddTrain(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String name = trainName.Text;
            int seat = Convert.ToInt32(Seats.Text);
            objMyDal.addtrain(name, seat);
            message.InnerHtml = Convert.ToString("Train Added Successfully!!!!");
            trainName.Text = String.Empty;
            Seats.Text = String.Empty;
        }
        protected void AddStation(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String name = Station_Name.Text;
            String city = City.Text;
            objMyDal.addstation(name, city);
            message1.InnerHtml = Convert.ToString("Station Added Successfully!!!!");
            Station_Name.Text = String.Empty;
            City.Text = String.Empty;
        }
    }
}