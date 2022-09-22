<%@ Page Title="Lost Password" Language="C#" MasterPageFile="~/Master Pages/login.Master" AutoEventWireup="true" CodeBehind="lostpassword.aspx.cs" Inherits="Railways.Asp_Files.lostpassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lost Password</h1>
     <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
     
            <p>Email Address</p>
            <asp:TextBox ID="UserEmail" placeholder="Enter Email" runat="server"  Width="247px">
               </asp:TextBox>
               <br/>
             <p>Enter Your CNIC</p>
            <asp:TextBox ID="UserCNIC" placeholder="Enter CNIC" runat="server" Width="247px">
               </asp:TextBox>
			<br/>
            <br/>
    <asp:Button ID="Button11" runat="server" Text="Reset Password" OnClick="Button1_Click"/>
                   
</asp:Content>
