using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
namespace Railways.Asps
{
    public partial class resetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String pass = password.Text;
            String pass1 = reenterpassword.Text;
            if (pass.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter First Password");
                return;
            }
            else if (pass1.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Reenter Password");
                return;
            }
            else if(!pass.Equals(pass1)){
                message.InnerHtml = Convert.ToString("Error!!! Password Not Matched!!");
                return;
            }
            else
            {
                if (Session["Email"] == null)
                {
                    message.InnerHtml = Convert.ToString("Email Not Found");

                }
                else
                {
                    aler.Text = Session["Email"].ToString();
                    String email = aler.Text;
                    objMyDal.ValidInput(email, pass);
                }
            }
            password.Text = string.Empty;
            reenterpassword.Text = string.Empty;
            Response.Redirect("loginHomePage.aspx");
        }

    }
}