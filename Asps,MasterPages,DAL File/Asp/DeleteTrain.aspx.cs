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
    public partial class DeleteTrain : System.Web.UI.Page
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
            Session["DeletedTrain"] = DropDownList1.Text;
            objMyDal.AllTrainsGridAdmin(ref DT1);
            DropDownList1.DataSource = DT1;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "train_name";
            DropDownList1.DataValueField = "train_name";
            DropDownList1.DataBind();

            DataTable DT2 = new DataTable();
            Session["DeletedStation"] = DropDownList2.Text;
            objMyDal.showadminstation(ref DT2);
            DropDownList2.DataSource = DT2;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "station_name";
            DropDownList2.DataValueField = "station_name";
            DropDownList2.DataBind();
        }
        protected void deletetrain(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String S = Session["DeletedTrain"].ToString();
            int f=objMyDal.removetrain(S);
            if (f == 1)
            {
                message.InnerHtml = Convert.ToString("Train Removed Successfully!!!!");
            }
            else {
                message.InnerHtml = Convert.ToString("Error In Train Removing!!!!!!");
            }
        }
        protected void deletestation(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String S = Session["DeletedStation"].ToString();
            int f = objMyDal.removestation(S);
            if (f == 1)
            {
                message1.InnerHtml = Convert.ToString("Station Removed Successfully!!!!");
            }
            else
            {
                message1.InnerHtml = Convert.ToString("Error In Train Removing!!!!!!");
            }
        }
    }
}