using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Railways.DAL;
namespace Railways.Asp
{
    public partial class Addtrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            DataTable DT1 = new DataTable();
            Session["TraintripAdmin"] = DropDownList1.Text;
            Session["DepartureAdmin"] = DropDownList2.Text;
            Session["ArrivalAdmin"] = DropDownList3.Text;
            objMyDal.AllTrainsGridAdmin(ref DT1);
            DropDownList1.DataSource = DT1;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "train_name";
            DropDownList1.DataValueField = "train_name";
            DropDownList1.DataBind();

            DataTable DT2 = new DataTable();
            
            objMyDal.showadminstation(ref DT2);
            DropDownList2.DataSource = DT2;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "station_name";
            DropDownList2.DataValueField = "station_name";
            DropDownList2.DataBind();
            DropDownList3.DataSource = DT2;
            DropDownList3.DataBind();
            DropDownList3.DataTextField = "station_name";
            DropDownList3.DataValueField = "station_name";
            DropDownList3.DataBind();
        }
        protected void AddTrip(object sender, EventArgs e) {
            myDAL objMyDal = new myDAL();
            String trainname = Session["TraintripAdmin"].ToString();
            String dep = Session["DepartureAdmin"].ToString();
            String Arr = Session["ArrivalAdmin"].ToString();
            String Dep_d = depdate.Text;
            if (Dep_d.Equals("")) {
                message.InnerHtml = Convert.ToString("Error!!! Please Insert Departure Date");
                return;
            }
            DateTime Dep_time = Convert.ToDateTime(Dep_d);
            String arr_t = arrtime.Text;
            if (arr_t.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!! Please Insert Departure Date");
                return;
            }
            DateTime Arr_time = Convert.ToDateTime(arr_t);
            String f = Fare.Text;
            if (f.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!! Please Insert Departure Date");
                return;
            }
            int fare = Convert.ToInt32(f);
            int f1=objMyDal.AddTrip(trainname, dep, Arr, Dep_time, Arr_time, fare);
            if (f1 == 1)
            {
                message.InnerHtml = Convert.ToString("Trip Inserted Successfully!!!!!");
            }
            else {
                message.InnerHtml = Convert.ToString("Error In Generating Trip!!!");
            }
            Fare.Text = string.Empty;
            depdate.Text = string.Empty;
            arrtime.Text = string.Empty;
        }
    }
}