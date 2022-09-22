using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace Railways.Asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string CalculateSum(Int32 Num1, Int32 Num2)
        {
            Int32 Result = Num1 + Num2;
            return Result.ToString();
        }
    }
}