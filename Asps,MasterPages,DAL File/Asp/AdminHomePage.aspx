<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/AdminHome.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="Railways.Asps.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="icon" href="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" type="image/x-icon"/>
    <link href="Addtrain.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .Add {
border: none;
    font-family: "Times New Roman", Times, serif;
    border-bottom: 1px solid yellow;
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
    background-color:forestgreen;
    text-align:center;
    color:White;
    width:60%;
    outline:thin;
    height: 40px;
    font-size: 26px;
	font-weight: bold;
	border-radius: 10px;        
}
        </style>
    <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
<iframe class="vid1" width="760" height="315" src="https://www.youtube.com/embed/gHCrHEJaYgk" frameborder="0" allowfullscreen></iframe>
	<div style="position:fixed;top:35%; left:30%; text-align:center;">		
     <asp:Label ID="Label1" CssClass="Add" style="position:fixed;top:32%;left:20%;" runat="server" Text="Add Amount"></asp:Label>
    <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
               <p>Email Address Of User</p>
        <asp:TextBox ID="Email" placeholder="Enter Email" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>    
            <p>Enter Amount to Add</p>
        <asp:TextBox ID="Amount" placeholder="Enter Amount" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
        <asp:Button CssClass="addbutton" Style="left:0%;" ID="Button1" OnClick="AddAmount" runat="server" Text="Add Amount"/>
        
        </div>
</asp:Content>
