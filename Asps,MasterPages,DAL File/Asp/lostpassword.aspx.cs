using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
namespace Railways.Asp_Files
{
    public partial class lostpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
             Session["Email"] = UserEmail.Text;
            String email = UserEmail.Text;
            String cnic = UserCNIC.Text;
            if (email.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Email");
                return;
            }
            else if (cnic.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter CNIC");
                return;
            }
            else
            {

                int i = objMyDal.ValidemailandCNIC(email, cnic);
                if (i == 0)
                {
                    message.InnerHtml = Convert.ToString("Error(Email not Found)");
                    return;
                }
                if (i == 1)
                {
                    message.InnerHtml = Convert.ToString("Error(CNIC not Correct)");
                    return;
                }
            }

            UserEmail.Text = string.Empty;
            UserCNIC.Text = string.Empty;
           
            Response.Redirect("resetPassword.aspx");

        }
       

    }
}