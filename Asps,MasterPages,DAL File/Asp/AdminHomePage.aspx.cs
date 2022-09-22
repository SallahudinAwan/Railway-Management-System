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
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminEmail"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
        }
        
        protected void AddAmount(object sender, EventArgs e)
        {
            myDAL objMyDal = new myDAL();
            String S = Email.Text; int amount=0;
            if (Amount.Equals(""))
            {
                amount = 0;
            }
            else {

                amount = Convert.ToInt32(Amount.Text);
                
            }
            int found=objMyDal.addamount(S, amount);
            if (found == 0)
            {
                message.InnerHtml = Convert.ToString("Error!!! Email is Not Correct");
            }
            else {
                Email.Text = string.Empty;
                Amount.Text = string.Empty;
                message.InnerHtml = Convert.ToString("Amount Added Successfully!!!!");
            }
        }
    }
}