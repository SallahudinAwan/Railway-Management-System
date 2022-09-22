using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;
using System.Data;
namespace Railways.Asps
{
    public partial class UserFeeback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email"] == null)
            {
                Response.Redirect("error.aspx");
                return;
            }
        }
        
        protected void Submit_Feedback(object sender, EventArgs e) {
            myDAL objMyDal = new myDAL();
            String Feed = TextArea1.InnerText;
            String email = Session["Email"].ToString();
            objMyDal.insert_feedback(email, Feed);
            message.InnerHtml = Convert.ToString("FeedBack Inserted Successfully!!!!!");
            TextArea1.InnerText = string.Empty;
        }
    }
}