using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Railways.DAL;

namespace Railways.Asp_Files
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public void Insert()
        { 
                myDAL objMyDal = new myDAL();
                String Firstname = First_Name.Text;
                String lastname = Last_Name.Text;
                String email = Email.Text;
                String cnic = CNIC.Text;
                String phone = Phone.Text;
                String pass = Password.Text;
            int size = email.Length;
            
            if (Firstname.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(First Name Is Empty)");
                return;
            }
            else if (lastname.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Last Name Is Empty)");
                return;
            }
            else if (email.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Email Is Empty)");
                return;
            }
            else if (cnic.Equals(""))
            {
                
                message.InnerHtml = Convert.ToString("Registeration Error(CNIC Is Empty)");
                return;
            }
            else if (phone.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Phone Is Empty)");
                return;
            }
            else if (pass.Equals(""))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Password Is Empty)");
                return;
            }
            String check = email.Substring(size - 10);
            if (!check.Equals("@gmail.com"))
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Email must have domain(gmail.com) )");
                return;
            }
            //          else if(email[size]!='m'&& email[size-1] != '0' &&email[size-2] != 'o' && email[size - 3] != '.' && email[size - 4] != 'l' && email[size - 5] != 'i' && email[size - 6] != 'a' && email[size - 7] != 'm' && email[size - 8] != 'o')
            else if (pass.Length < 10)
            {
                message.InnerHtml = Convert.ToString("Registeration Error(Password Must be Greater than 10 Characters)");
                return;
            }

            else
            {

                int age = Convert.ToInt32(Age.Text);
                if (objMyDal.ValidInput(Firstname, lastname, email, cnic, phone, pass, age) == 0)
                {
                    message.InnerHtml = Convert.ToString("Register Successfully ");
                   // LinkButton1.Text = "Login Now";
                }
                else
                {
                    message.InnerHtml = Convert.ToString("Registeration Error(Email found!!Kindly Choose Different Email)");
                    return;
                }
            }
            First_Name.Text = string.Empty;
            Last_Name.Text = string.Empty;
            Email.Text = string.Empty;
            CNIC.Text = string.Empty;
            Phone.Text = string.Empty;
            Password.Text = string.Empty;
            Age.Text = string.Empty;
            Session["EmailAddress"] = Email.Text;


            Response.Redirect("userlogin.aspx");
        }

        protected void button_click(object sender, EventArgs e)
        {
           
            Insert();
        }

    }
}