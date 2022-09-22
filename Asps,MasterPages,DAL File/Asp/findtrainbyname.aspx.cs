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
    public partial class findtrainbyname : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
            if (Session["Fromstationfindtrain"] != null)
            {
                myDAL objMyDal = new myDAL();
                //string Tno = Session["Trainno"].ToString();
                string fo = Session["Fromstationbytrainname"].ToString();
                string to = Session["tostationbytrainname"].ToString();
                string train = Session["Trainname"].ToString();
                String S = train+" (";
                S = S + fo; S = S + " - ";
                S = S + to; S = S + " )";
                Ftrain.Text = S;
                DataTable DT1 = new DataTable();
                int found = 0;
                objMyDal.fintrainbynameingrid(ref DT1, fo, to, train, ref found);//seting data source for this Grid
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