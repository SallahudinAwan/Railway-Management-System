<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Railways.Asp_Files.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="Register.css" rel="stylesheet" />
     <link rel="icon" href="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" type="image/x-icon"/>

</head>
<body>
   <form id="form1" runat="server">
   <img  style="position:relative; left:40px; background-color:white; background-color:white;border-radius:40px; box-shadow: 0 8px 16px 0 rgba(0,0,0,2), 0 6px 25px 0 rgba(0,0,0,19);width: 12%;top:15px;height:12%;" src="https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/State_emblem_of_Pakistan.svg/280px-State_emblem_of_Pakistan.svg.png"/>
     <div class="loginbox">
    <img src="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" class="avatar"/>
        <h2><b><i>Pakistan Railways</i></b></h2>
		<h1>Sign Up Here</h1>
            
            
            <script>
            function Refresh() {
                var fname= document.getElementById("First_Name").value;
                var lname = document.getElementById("Last_Name").value;
                var cnic = document.getElementById("CNIC").value;
                var phone = document.getElementById("Phone").value;
                var email = document.getElementById("Email").value;
                var age = document.getElementById("Age").value;
                var pass = document.getElementById("Password").value;
               
                age = parseInt(age);
             
                if (Number.isInteger(age)) {
                    if (age < 10) { 
                        document.getElementById("Age").value = "18";
                        document.getElementsById("message").value = "Register Successfully with Age Error(Age Must be >10) , Default Set=18"
                    }
                }                   
                else {
                    document.getElementById("Age").value = "18";
                    document.getElementsById("message").value = "Register Successfully with Age Error(Must be Integer) , Default Set=18 "
                }
            }
</script>
        <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
        <center>
            
        <p>First Name</p>
            <asp:TextBox ID="First_Name" placeholder="Enter First Name" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
            <p>Last Name</p>
        <asp:TextBox ID="Last_Name" placeholder="Enter Last Name" AutoCompleteType="LastName" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
			<p>Email Address</p>
        <asp:TextBox ID="Email" placeholder="Enter Email Address" AutoCompleteType="Email" runat="server" Width="447px">
               </asp:TextBox>
           <br/>    
        <p>CNIC No</p>
        <asp:TextBox ID="CNIC" placeholder="Enter CNIC" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>    
        <p>Phone Number</p>
        <asp:TextBox ID="Phone" placeholder="Enter Phone Number" AutoCompleteType="HomePhone" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
            <p>Age</p>
            <asp:TextBox ID="Age" placeholder="Enter Age" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
        <p>Password</p>
         <asp:TextBox ID="Password" placeholder="Enter Password" type="Password" runat="server" Width="447px">
               </asp:TextBox>
         
               
			</center>
			
        <!--<form id="Form2" action="Register.aspx" method="Post">
			<input type="submit"  value="Login" onclick="Insert"/>
			</form>-->
             
        <asp:Button ID="Button1" runat="server" Text="Register" OnClientClick="Refresh()" OnClick="button_click"/>
       
			<br/>
    </div>
    </form>
</body>
</html>
