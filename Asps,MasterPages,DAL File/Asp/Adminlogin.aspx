<%@ Page Title="Admin Login" Language="C#" MasterPageFile="~/Master Pages/login.Master" AutoEventWireup="true" CodeBehind="Adminlogin.aspx.cs" Inherits="Railways.Asp_Files.Adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="icon" href="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" type="image/x-icon"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Login Here</h1>
     <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
            <p>Admin Email Address</p>
            <asp:TextBox ID="Email" placeholder="Enter Correct Email" runat="server"  Width="247px">
               </asp:TextBox>
               <br/>
             <p>Admin Password</p>
            <asp:TextBox ID="password" placeholder="Enter Correct Password" type="Password" runat="server" Width="247px">
               </asp:TextBox>
			<br/>
            <br/>
            <asp:Button ID="Button12" runat="server" Text="Admin Login" OnClick="Button1_Click"/>
            <a class="link" href="userlogin.aspx">User Login</a>
        
        
        
</asp:Content>
