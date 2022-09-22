using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
namespace Railways.Asp_Files
{
    public partial class userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Email"] = null;
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            Session["Email"] = Email.Text;
            String email = Email.Text;
            String pass = password.Text; 
            if (email.Equals(""))//if email is empty
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Email");
                return;
            }
            else if (pass.Equals(""))//if password is empty
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Password");
                return;
            }
            else
            {
                int i = objMyDal.Validemail(email, pass);
                                
                if (i == 0)
                {
                    message.InnerHtml = Convert.ToString("Login Error(Email not Found)");
                    return;
                }
                if (i == 1)
                {
                    message.InnerHtml = Convert.ToString("Login Error(password not Correct)");
                    return;
                }
                message.InnerHtml = Convert.ToString("Login Successfully");
            }

            Email.Text = string.Empty;
            password.Text = string.Empty;
            Response.Redirect("loginHomePage.aspx");

        }
    }
}