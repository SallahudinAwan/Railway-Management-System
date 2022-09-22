<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="Findtrainbyfare.aspx.cs" Inherits="Railways.Asp.Findtrainbyfare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
.popular1{
	font-family: "Times New Roman", Times, serif;
	text-decoration-line: none;
    text-decoration-style: solid;
	color:white;
    margin: 10px;
    background-color:green;
	position:relative;
	 top: 4%;
    left: 33%;
    border-radius:20px;
    padding: 10px 120px 10px;
    text-align: center;
    font-size: 25px;
}

.mydatagrid
{
top:13%;
left:25%;
text-align:center;
position:fixed;
border: solid 2px black;
min-width: 70%;
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
font-size: 14px;
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
    <asp:Label CssClass="popular1" ID="Ftrain" runat="server" Text="Find Train(Departure-Destination)  "></asp:Label>               
    <asp:GridView ID="GridView1" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" runat="server" >
    </asp:GridView>
    <div style="position:fixed;left:42%; top:14%; background-color:#ffc107;color:red; font-weight: bold;border-radius:0px; font-size: 20px;" id="message" runat="server">
                     </div></Center><br/>

</asp:Content>
