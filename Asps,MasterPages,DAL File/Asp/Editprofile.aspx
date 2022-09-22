<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="Editprofile.aspx.cs" Inherits="Railways.Asps.Editprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<style>
    
.line1{
	height:27px;
	width:70%;
	border-width:5px;
	border-color:yellow;
    border-radius:20px;
	color:green;
	position:relative;
	top:4.5%;
	left:25%;
	background-color:green;

}
.popular1{
	font-family: "Times New Roman", Times, serif;
	text-decoration-line: none;
    text-decoration-style: solid;
	color:white;
    margin: 10px;
	position:relative;
	 top: 3%;
    left: 10%;
    padding: 0px 0px 0px;
    text-align: center;
    font-size: 25px;
}

.loginboxupdate{
    width: 520px;
    height:810px;
    background: white;
    color:white;
    top: 26%;
    left: 60%;
    position: absolute;
    transform: translate(-50%,-50%);
    box-sizing: border-box;
    padding: 20px 30px;
	border-radius: 20px;
}

.loginboxupdate input{
    width: 160%;
    margin-bottom: 20px;
}
.loginboxupdate p{
    margin: 0;
    padding: 0;
    text-align:center;
    font-weight: bold;
	color:green;
}
.loginboxupdate input[type="text"], input[type="password"],input[type="email"]
{
    border: none;
	box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    border-bottom: 1px solid #fff;
    background: #ffc107;
    color: green;
    text-align:center;
    outline: none;
    height: 40px;
    width:40%;
    font-size: 16px;
	font-weight: bold;
	border-radius: 10px;
}

.loginboxupdate input[type="submit"]
{
    border: none;
    outline: none;
    height: 30px;
    background: green;
    width:100%;
    color: white;
    font-size: 18px;
    border-radius: 20px;
	
}
.loginboxupdate input[type="submit"]:hover
{
    cursor: pointer;
    background: #ffc107;
    color: green;#000;
	animation-name: example;
  animation-duration: 10s;
  animation-iteration-count: infinite;
}

</style>

            <hr class="line1"/>
			<h1 class="popular1">Edit Profile</h1>
   
			<div class="loginboxupdate">
                <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
			<p>Email Address</p>
            <asp:TextBox type="text" Style="background-color:burlywood;" ID="email" placeholder="Email Address Cannot Changed" ReadOnly="true" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
                <p>Wallet</p>
            <asp:TextBox type="text" Style="background-color:burlywood;" ID="Wallet" placeholder="Wallet" ReadOnly="true" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
            <p>First Name</p>
                <asp:TextBox type="text" ID="firstName" placeholder="Enter First Name" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
            <p>Last Name</p>
            <asp:TextBox type="text" ID="lastname" placeholder="Enter Last Name" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
                <p>CNIC No</p>
            <asp:TextBox type="text" ID="cnic" placeholder="Enter CNIC" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
                <p>Phone Number</p>
            <asp:TextBox type="text" ID="phone" placeholder="Enter Phone Number" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
                <p>Age</p>
            <asp:TextBox type="text" ID="age" placeholder="Enter Age" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
                
			 <asp:Button CssClass="buttontrain" ID="Button1" runat="server" OnClick="updateprofile" Text="Update"/>
       
			</div>
       
</asp:Content>
