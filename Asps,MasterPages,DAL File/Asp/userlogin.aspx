<%@ Page Title="Railways Login" Language="C#" MasterPageFile="~/Master Pages/login.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="Railways.Asp_Files.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login Here</h1>
     <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
            <p>Email Address</p>
            <asp:TextBox ID="Email" placeholder="Enter Correct Email" runat="server"  Width="247px">
            </asp:TextBox>
            <br/>
            <p>Password</p>
            <asp:TextBox ID="password" placeholder="Enter Correct Password" type="Password" runat="server" Width="247px">
           </asp:TextBox>
			<br/>
            <br/>
            <asp:Button ID="Button12" runat="server" Text="Login" OnClick="Button1_Click"/>
            <a class="link" href="lostpassword.aspx">Lost your password?</a><br/>
            <a class="link" href="Register.aspx">Don't have an account?</a><br/>
            <a class="link" href="Adminlogin.aspx">Admin Login</a>
        
</asp:Content>
