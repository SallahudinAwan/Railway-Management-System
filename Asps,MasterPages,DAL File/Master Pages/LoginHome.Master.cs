using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Railways.DAL;
namespace Railways.Master_Pages
{
    public partial class LoginHome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            myDAL objMyDal = new myDAL();
            if (Session["Email"] != null)
            {
                Username.Text = Session["Email"].ToString();
                String S = Username.Text;
                String name = "";
                objMyDal.findname(S, ref name);
                name = "Hi, " + name;
                Username.Text = name;
            }
            Session["Fromstationbytrainname"] = DropDownList4.Text;
            Session["tostationbytrainname"] = DropDownList5.Text;
            Session["Trainname"] = DropDownList6.Text;
            Session["Fromstationfindtrain"] = DropDownList7.Text;
            Session["tostationfindtrain"] = DropDownList8.Text;
            Session["MaxFare"] = DropDownList9.Text;
            Session["Fromstationfare"] = DropDownList2.Text;
            Session["tostationfare"] = DropDownList3.Text;
            
            DataTable DT = new DataTable();
            objMyDal.AllTrainsGridAdmin(ref DT);
            DropDownList6.DataSource = DT; 
            DropDownList6.DataBind();
            DropDownList6.DataTextField = "train_name";
            DropDownList6.DataValueField = "train_name";
            DropDownList6.DataBind();
            
           
            String S1 = DropDownList9.Text;
            DataTable DT1 = new DataTable();
            objMyDal.showadminstation(ref DT1);
            DropDownList2.DataSource = DT1;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "station_name";
            DropDownList2.DataValueField = "station_name";
            DropDownList2.DataBind();

            DropDownList4.DataSource = DT1;
            DropDownList4.DataBind();
            DropDownList4.DataTextField = "station_name";
            DropDownList4.DataValueField = "station_name";
            DropDownList4.DataBind();

            
            
            String S2 = DropDownList6.Text;
            DropDownList7.DataSource = DT1;
            DropDownList7.DataBind();
            DropDownList7.DataTextField = "station_name";
            DropDownList7.DataValueField = "station_name";
            DropDownList7.DataBind();

            DataTable DT2 = new DataTable();
            objMyDal.showadminstation(ref DT2);
            DropDownList3.DataSource = DT2;
            DropDownList3.DataBind();
            DropDownList3.DataTextField = "station_name";
            DropDownList3.DataValueField = "station_name";
            DropDownList3.DataBind();

            DropDownList8.DataSource = DT2;
            DropDownList8.DataBind();
            DropDownList8.DataTextField = "station_name";
            DropDownList8.DataValueField = "station_name";
            DropDownList8.DataBind();

            DropDownList5.DataSource = DT2;
            DropDownList5.DataBind();
            DropDownList5.DataTextField = "station_name";
            DropDownList5.DataValueField = "station_name";
            DropDownList5.DataBind();

        }
        protected void calculatefare(object sender, EventArgs e) {
            //Session["Fromstationfare"] = DropDownList2.Text;
            //String S = DropDownList2.Text; 
            //Session["tostationfare"] = DropDownList3.Text;
            //String S1 = DropDownList3.Text;
            Response.Redirect("Calculatefare.aspx");
        }
        protected void FindTrainbyfare(object sender, EventArgs e)
        {
            //Session["Trainno"] = DropDownList1.Text;
            //Session["Fromstationfindtrain"] = DropDownList7.Text;
            //Session["tostationfindtrain"] = DropDownList8.Text;
            //Session["MaxFare"] = DropDownList9.Text;
            //String S = DropDownList9.Text;
            Response.Redirect("Findtrainbyfare.aspx");
        }
        protected void FindTrainbytrainname(object sender, EventArgs e)
        {
            //Session["Trainno"] = DropDownList1.Text;
           // Session["Fromstationbytrainname"] = DropDownList4.Text;
            //Session["tostationbytrainname"] = DropDownList5.Text;
           // Session["Trainname"] = DropDownList6.Text;
            //String S = DropDownList9.Text;
            Response.Redirect("findtrainbyname.aspx");
        }

        public static string Name()
        {
            string Name = "Hello Rohatash Kumar";
            return Name;
        }
        protected void button_load(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }
    }
}