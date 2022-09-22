using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
namespace Railways.Asps
{
    public partial class Editprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] != null)
            {
                myDAL objMyDal = new myDAL();
                email.Text = Session["Email"].ToString();
                String Email = email.Text;
                int wallet=0;
                objMyDal.findwallet(Email, ref wallet);
                String S ="Wallet = "+ wallet.ToString();
                Wallet.Text = wallet.ToString();
            }
            else {
                   Response.Redirect("error.aspx");    
            }
        }
        protected void updateprofile(object sender, EventArgs e) {
            myDAL objMyDal = new myDAL();
            String Email = email.Text;
            String last = lastname.Text;
            String first = firstName.Text;
            String cni = cnic.Text;
            String phon = phone.Text;
            String A = age.Text;
            if (first.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter first Name");
                return;
            }
            if (last.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Last Name");
                return;
            }
           
            if (cnic.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter CNIC");
                return;
            }
            if (phon.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Phone Number");
                return;
            }
            if (A.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Error!!!Please Enter Age");
                return;
            }
            else {
                int ag = Convert.ToInt32(age.Text);
                objMyDal.editprofile(Email,first, last, cni, phon, ag);
                message.InnerHtml = Convert.ToString("SuccessFully Updated Your Profile");
            }

        }
    }
}