using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Railways.DAL
{
    public class myDAL
    {
        private static readonly string connString =
          System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

       // public DataSet SelectUsers() //to get the values of all the items from table Items and return the Dataset
       // {

       //     DataSet ds = new DataSet(); //declare and instantiate new dataset
       //     SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
       //     con.Open(); // open sql Connection
       //     SqlCommand cmd;
       //     try
       //     {
       //         cmd = new SqlCommand("select U.first_name,U.last_name from Users U", con);  //instantiate SQL command 
       //         cmd.CommandType = CommandType.Text; //set type of sqL Command
       //         using (SqlDataAdapter da = new SqlDataAdapter(cmd))
       //         {
       //             da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
       //         }
       //     }
       //     catch (SqlException ex)
       //     {
       //         Console.WriteLine("SQL Error" + ex.Message.ToString());
       //     }
       //     finally
       //     {
       //         con.Close();
       //     }

       //     return ds; //return the dataset
       // }
       // public void Insert(String firstame, String lastame, int age, String CNIC, String Email, String Mobile, String Password)
       // {
       //     DataSet ds = new DataSet();
       //     SqlConnection con = new SqlConnection(connString);
       //     con.Open();
       //     SqlCommand cmd;
       //     try
       //     {
       //         cmd = new SqlCommand("InsertUser", con); //name of your procedure
       //         cmd.CommandType = CommandType.StoredProcedure;

       //         cmd.Parameters.Add("@firstame", SqlDbType.VarChar, 225);
       //         cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 225);
       //         cmd.Parameters.Add("@age", SqlDbType.Int);
       //         cmd.Parameters.Add("@CNIC", SqlDbType.VarChar, 15);
       //         cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
       //         cmd.Parameters.Add("@Mobile", SqlDbType.VarChar, 11);
       //         cmd.Parameters.Add("@password", SqlDbType.VarChar, 50);
                
       //         // set parameter values
       //         cmd.Parameters["@firstame"].Value = firstame;
       //         cmd.Parameters["@lastname"].Value = lastame;
       //         cmd.Parameters["@age"].Value = age;
       //         cmd.Parameters["@CNIC"].Value = CNIC;
       //         cmd.Parameters["@Email"].Value = Email;
       //         cmd.Parameters["@Mobile"].Value = Mobile;
       //         cmd.Parameters["@password"].Value = Password;


       //         cmd.ExecuteNonQuery();
                
       //         con.Close();


       //     }
       //     catch (SqlException ex)
       //     {
       //         Console.WriteLine("SQL Error" + ex.Message.ToString());

       //     }
       //     finally
       //     {
       //         con.Close();
       //     }
           
       // }
       // //public void InsertUser(String firstame,ref String Password)
       //// {
       //  public void Test()
       // {
       //     SqlConnection con = new SqlConnection(connString);
       //     con.Open();
          
       //         SqlCommand sql_cmnd = new SqlCommand("UserIn2", con);
       //         sql_cmnd.CommandType = CommandType.StoredProcedure;
                
       //         sql_cmnd.ExecuteNonQuery();
       //         con.Close();
            
       // }
       // public void Test1(String firstname, String lastname, String email, String Cnic, String phone, String pass,int age)
       // {
       //     SqlConnection con = new SqlConnection(connString);
       //     con.Open();
       //     SqlCommand sql_cmnd = new SqlCommand("InsertUser", con);
       //     sql_cmnd.CommandType = CommandType.StoredProcedure;
       //     sql_cmnd.Parameters.AddWithValue("@first_name", SqlDbType.VarChar).Value = firstname;
       //     sql_cmnd.Parameters.AddWithValue("@last_name", SqlDbType.VarChar).Value = lastname;
       //     sql_cmnd.Parameters.AddWithValue("@age", SqlDbType.Int).Value = age;
       //     sql_cmnd.Parameters.AddWithValue("@CNIC", SqlDbType.VarChar).Value = Cnic;
       //     sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
       //     sql_cmnd.Parameters.AddWithValue("@mobile_no", SqlDbType.VarChar).Value = phone;
       //     sql_cmnd.Parameters.AddWithValue("@Password1", SqlDbType.VarChar).Value = pass;
       //     sql_cmnd.ExecuteNonQuery();
       //     con.Close();
       // }

       /*Function TO Register the User and return That it is successfull or not*/ 
        public int ValidInput(String firstname, String lastname, String email, String Cnic, String phone, String pass, int age)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("InsertValidUser", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@first_name", SqlDbType.VarChar).Value = firstname;
            sql_cmnd.Parameters.AddWithValue("@last_name", SqlDbType.VarChar).Value = lastname;
            sql_cmnd.Parameters.AddWithValue("@age", SqlDbType.Int).Value = age;
            sql_cmnd.Parameters.AddWithValue("@CNIC", SqlDbType.VarChar).Value = Cnic;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@mobile_no", SqlDbType.VarChar).Value = phone;
            sql_cmnd.Parameters.AddWithValue("@Password1", SqlDbType.VarChar).Value = pass;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
           
            con.Close();
            return found;
        }
        /*Function to add the wallet to the user account*/
        public int addamount(String email,int amount)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("Addwallet", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@price", SqlDbType.Int).Value = amount;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
            return found;
        }
        /*Function to Remove the Train*/
        public int removetrain(String name){
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found=0;
            try {
                SqlCommand sql_cmnd = new SqlCommand("deletetrain", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = name;
                sql_cmnd.ExecuteNonQuery();
                found = 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                found = 0;
            }
            finally
            {
                con.Close();    
            }
            return found;
        }
        /*Function to Remove the Station*/
        public int removestation(String name)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found = 0;
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("deleteStation", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = name;
                sql_cmnd.ExecuteNonQuery();
                found = 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                found = 0;
            }
            finally
            {
                con.Close();
            }
            return found;
        }
        /*Function to Add the Train*/
        public void addtrain(String trainname, int seats)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("Addtrain", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = trainname;
            sql_cmnd.Parameters.AddWithValue("@seats", SqlDbType.Int).Value = seats;
            
            sql_cmnd.ExecuteNonQuery();
            
            con.Close();
           
        }
        /*Function to Add the Station*/
        public void addstation(String trainname, String city)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("Addstation", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = trainname;
            sql_cmnd.Parameters.AddWithValue("@city", SqlDbType.VarChar).Value = city;

            sql_cmnd.ExecuteNonQuery();

            con.Close();

        }
        /*Function to Check User Email and Password is correct or Not*/
        public int Validemail( String email, String pass)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("Validemailpass", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@Password1", SqlDbType.VarChar).Value = pass;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
            return found;
        }
        /*Function to Check Admin Email and Password is correct or Not*/
        public int AdminValidemail(String email, String pass)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("AdminValidemailpass", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@Password1", SqlDbType.VarChar).Value = pass;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
            return found;
        }
        /*Function to Check Email and CNIC is correct or Not, Because After this we Reset the Password*/
        public int ValidemailandCNIC(String email, String cnic)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("ValidemailCNIC", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@CNIC", SqlDbType.VarChar).Value = cnic;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
            return found;
        }
        /*Function to Pay the Ticket Means Minus that ammount from the Account of User*/
        public int Payment(String email,int Amount)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("minuswallet", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@price", SqlDbType.Int).Value = Amount;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
            return found;
        }
        /*Function to User Insert Feedback*/
        public void insert_feedback(String email, String Feedback)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("insert_feedback", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@feedback", SqlDbType.VarChar).Value = Feedback;
            sql_cmnd.ExecuteNonQuery();
            con.Close();
         }
        /*Function to Show Feedback to Admin*/
        public void show_feedback(ref DataTable DT)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("show_feedback", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.ExecuteNonQuery();
            using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
            {
                da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
            }
            con.Close();
        }
        /*Function to Find Ticket by Ticket-ID, Use in Ticket Informaion*/
        public int findticket(ref DataTable DT, int ticket)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("findticketbyNumber", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@ticket_no", SqlDbType.Int).Value = ticket;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
            using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
            {
                da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
            }

            con.Close();
            return found;
        }
        /*Function to Print All The Generated Tickets, Use in Booking Pages*/
        public int findmanyticket(ref DataTable DT, int ticket,int last)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("findmanyticket", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@ticket_no", SqlDbType.Int).Value = ticket;
            sql_cmnd.Parameters.AddWithValue("@last", SqlDbType.Int).Value = last;

            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
            using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
            {
                da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
            }

            con.Close();
            return found;
        }
        /*Function to Delete Ticket*/
        public void deleteticket(int ticket)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("deleteticket", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Ticket_id", SqlDbType.Int).Value = ticket;
            
            sql_cmnd.ExecuteNonQuery();
            con.Close();
        }
        /*Function to Generate Ticket In Booking Pages*/
        public int generateticket(String Email,int trainno,int tripno,DateTime dep_time,ref int ticketnumber)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found;
            SqlCommand sql_cmnd = new SqlCommand("InsertTicket_p", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = Email;
            sql_cmnd.Parameters.AddWithValue("@train_no", SqlDbType.Int).Value = trainno;
            sql_cmnd.Parameters.AddWithValue("@trip_ID", SqlDbType.Int).Value = tripno;
            sql_cmnd.Parameters.AddWithValue("@departure_time", SqlDbType.DateTime).Value = dep_time;
            sql_cmnd.Parameters.Add("@TICKETID", SqlDbType.Int).Direction = ParameterDirection.Output;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            sql_cmnd.ExecuteNonQuery();

            ticketnumber = Convert.ToInt32(sql_cmnd.Parameters["@TICKETID"].Value); //convert to output parameter to interger format

            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
            
            con.Close();
            return found;
        }
        /*Function to Reset Password of User*/
        public void ValidInput( String email, String pass)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("resetpassword", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
             sql_cmnd.ExecuteNonQuery();
            con.Close();
        }
        /*Function to Edit Profile of user*/
        public void editprofile(String email, String firstname, String lastname, String cnic, String Phone,int age)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("editprofile", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@first_name", SqlDbType.VarChar).Value = firstname;
            sql_cmnd.Parameters.AddWithValue("@last_name", SqlDbType.VarChar).Value = lastname;
            sql_cmnd.Parameters.AddWithValue("@age", SqlDbType.VarChar).Value =age ;
            sql_cmnd.Parameters.AddWithValue("@CNIC", SqlDbType.VarChar).Value = cnic;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.AddWithValue("@mobile_no", SqlDbType.VarChar).Value = Phone;
            sql_cmnd.ExecuteNonQuery();
            con.Close();
        }
        /*Function to Find Name of User and Print it On the Top Right Corner After Login*/
        public void findname(String email,ref String name)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("findlastname", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.Add("@Name", SqlDbType.VarChar, 255);
            sql_cmnd.Parameters["@Name"].Direction = ParameterDirection.Output;
            sql_cmnd.ExecuteNonQuery();

            name = sql_cmnd.Parameters["@Name"].Value.ToString();
            con.Close();
        }
        /*Function to Find The Wallet Amount of User and Show it in Edit Profile*/
        public void findwallet(String email, ref int wallet)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("getwallet", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
            sql_cmnd.Parameters.Add("@Wallet", SqlDbType.Int, 255);
            sql_cmnd.Parameters["@Wallet"].Direction = ParameterDirection.Output;
            sql_cmnd.ExecuteNonQuery();

            wallet = Convert.ToInt32(sql_cmnd.Parameters["@Wallet"].Value); //convert to output parameter to interger format
            con.Close();
        }
        /*Function to Delete Ticket and Refund the User as well*/
        public void deleteticketbyid(int ticket,ref int found)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("deleteticketbyid", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@ticket_no", SqlDbType.Int).Value = ticket;
            sql_cmnd.Parameters.Add("@found", SqlDbType.Int).Direction = ParameterDirection.Output;
            
            sql_cmnd.ExecuteNonQuery();
            found = Convert.ToInt32(sql_cmnd.Parameters["@found"].Value); //convert to output parameter to interger format

            con.Close();
        }
        /*Function to Get Informaion About fare and Trip Id and Dep Time and all*/
        public void gettripinformation(String departure,String arrival,int trainno,ref int fare,ref int trip_id,ref DateTime dep_time,ref int found)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand sql_cmnd = new SqlCommand("outputTrainDetails", con);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@orig_station", SqlDbType.VarChar).Value = departure;
            sql_cmnd.Parameters.AddWithValue("@dest_station", SqlDbType.VarChar).Value = arrival;
            sql_cmnd.Parameters.AddWithValue("@trainno", SqlDbType.VarChar).Value = trainno;
          
            sql_cmnd.Parameters.Add("@Fare", SqlDbType.Int).Direction = ParameterDirection.Output;
            sql_cmnd.Parameters.Add("@tripid", SqlDbType.Int).Direction = ParameterDirection.Output;
            sql_cmnd.Parameters.Add("@Departure", SqlDbType.DateTime).Direction = ParameterDirection.Output;
            sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            
            sql_cmnd.ExecuteNonQuery();
            fare = Convert.ToInt32(sql_cmnd.Parameters["@Fare"].Value); //convert to output parameter to interger format
            trip_id = Convert.ToInt32(sql_cmnd.Parameters["@tripid"].Value); //convert to output parameter to interger format
            dep_time = DateTime.Parse(sql_cmnd.Parameters["@Departure"].Value.ToString());
            found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format

            con.Close();
        }
        /*Function to Show the Trains Informaion like train Name in the Drop Down Menus */
        public void showTrainsingrid(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select train_name from Train", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

           
        }
        /*Function to Print the From Station where trains Origin*/
        public void showFromStation(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("FromStation", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print the To Station where trains Arrival*/
        public void showtoStation(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("ToStation", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
                {
                    da.Fill(DT); 
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print Train Informaion by Getting From Station to Station*/
        public void Calculatefareingrid(ref DataTable DT,String from,String To,ref int found) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("ShowTrainDetails", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@orig_station", SqlDbType.VarChar).Value = from;
                sql_cmnd.Parameters.AddWithValue("@dest_station", SqlDbType.VarChar).Value = To;
                sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;
                sql_cmnd.ExecuteNonQuery();
                found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
                using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print Train Informaion by Getting From Station to Station and With fare*/
        public void findtrainingrid(ref DataTable DT, String from, String To,int fare, ref int found) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("Showtrainsbyfare", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@orig_station", SqlDbType.VarChar).Value = from;
                sql_cmnd.Parameters.AddWithValue("@dest_station", SqlDbType.VarChar).Value = To;
                sql_cmnd.Parameters.AddWithValue("@fare", SqlDbType.VarChar).Value = fare;
                sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;
                sql_cmnd.ExecuteNonQuery();
                found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
                using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print Train Informaion by Getting From Station to Station and With train Name*/
        public void fintrainbynameingrid(ref DataTable DT, String from, String To,String Trainname, ref int found) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("Showtrainsbytrainname", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@orig_station", SqlDbType.VarChar).Value = from;
                sql_cmnd.Parameters.AddWithValue("@dest_station", SqlDbType.VarChar).Value = To;
                sql_cmnd.Parameters.AddWithValue("@trainname", SqlDbType.VarChar).Value = Trainname;
                sql_cmnd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;
                sql_cmnd.ExecuteNonQuery();
                found = Convert.ToInt32(sql_cmnd.Parameters["@Found"].Value); //convert to output parameter to interger format
                using (SqlDataAdapter da = new SqlDataAdapter(sql_cmnd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print All Stations Detail*/
        public void findtrainbyfareingrid(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select * from Station", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        /*Function to Print Trains Names In Admin Pages*/
        public void AllTrainsGridAdmin(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select train_name from Train", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /*Function to Print Stations Names In Admin Pages*/
        public void AllStationsGridAdmin(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select station_name from Station", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /*Function to Print Stations Names In Admin Pages*/
        public void showadminstation(ref DataTable DT) //to get the values of all the items from table Items and return the Dataset
        {
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select station_name from Station", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(DT); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /*Function to Add trip In Admin Pages */
        public int AddTrip(String Trainname, String FromStation, String toStation, DateTime dep_time, DateTime arr_time,int fare)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            int found=1;
            try {
                SqlCommand sql_cmnd = new SqlCommand("generateTrip", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@orgin_station", SqlDbType.VarChar).Value = FromStation;
                sql_cmnd.Parameters.AddWithValue("@dest_station", SqlDbType.VarChar).Value = toStation;
                sql_cmnd.Parameters.AddWithValue("@Fare", SqlDbType.Int).Value = fare;
                sql_cmnd.Parameters.AddWithValue("@train_name", SqlDbType.VarChar).Value = Trainname;
                sql_cmnd.Parameters.AddWithValue("@departure_time", SqlDbType.DateTime).Value = dep_time;
                sql_cmnd.Parameters.AddWithValue("@arrival_time", SqlDbType.DateTime).Value = arr_time;

                sql_cmnd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            return found;
        }
    }
}