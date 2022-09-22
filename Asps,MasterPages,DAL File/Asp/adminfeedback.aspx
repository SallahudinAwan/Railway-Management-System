<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/AdminHome.Master" AutoEventWireup="true" CodeBehind="adminfeedback.aspx.cs" Inherits="Railways.Asp.adminfeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        
.mydatagrid
{
top:15%;
left:4%;
text-align:center;
position:fixed;
border: solid 2px black;
min-width: 20%;
}
.header
{
background-color:green;
font-family: Arial;
color: White;
border: none 0px transparent;
height: 25px;
text-align: center;
font-size: 16px;
}

.rows
{
background-color: #fff;
font-family: Arial;
font-size: 11.5px;
color: #000;
text-align: center;
min-height: 25px;
border: none 0px transparent;
}
.rows:hover
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
text-align: center;
}
.selectedrow
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
font-weight: bold;
text-align: center;
}
.mydatagrid a /** FOR THE PAGING ICONS **/
{
background-color: Transparent;
padding: 5px 5px 5px 5px;
color: #fff;
text-decoration: none;
font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
{
background-color: #000;
color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
background-color: #c9c9c9;
color: #000;
padding: 5px 5px 5px 5px;
}
.pager
{
background-color: #646464;
font-family: Arial;
color: White;
height: 30px;
text-align: left;
}

.mydatagrid td
{
padding: 5px;
}
.mydatagrid th
{
padding: 5px;
}
        </style>
     <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
     <asp:Label ID="Label1" CssClass="Add" style="position:fixed;top:12%;left:20%;" runat="server" Text="Feedbacks"></asp:Label>
    <asp:GridView ID="GridView1" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" runat="server" >
    
    </asp:GridView>

</asp:Content>
