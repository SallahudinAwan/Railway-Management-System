<%@ Page Title="Reset Password" Language="C#" MasterPageFile="~/Master Pages/login.Master" AutoEventWireup="true" CodeBehind="resetPassword.aspx.cs" Inherits="Railways.Asps.resetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Reset Password</h1>
     <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
    <asp:TextBox ID="aler" placeholder="Enter New Password" Type="Password" Visible="false" runat="server"  Width="247px">
               </asp:TextBox>
            <p>New Password</p>
            <asp:TextBox ID="password" placeholder="Enter New Password" Type="Password" runat="server"  Width="247px">
               </asp:TextBox>
               <br/>
             <p>Again New Password</p>
            <asp:TextBox ID="reenterpassword" placeholder="Reenter New Password" Type="Password" runat="server" Width="247px">
               </asp:TextBox>
			<br/>
            <br/>
    <asp:Button ID="Button11" runat="server" Text="Reset Password" OnClick="Button1_Click"/>

</asp:Content>
