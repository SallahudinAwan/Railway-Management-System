<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="payment.aspx.cs" Inherits="Railways.Asp.payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
.detail{
  font-family: "Times New Roman", Times, serif;
  color:green;
  position:relative;
  top:2.5%;
    padding: 0px 300px 0px 300px;
    text-align: center;
    font-size: 25px;

}

.container {
  color:green;
  position: relative;
  top:2.55%;
  left:5%;
  text-align:center;
  padding: 0px 350px 0px 300px;
  cursor: pointer;
  font-size: 18px;
}

input[type=submit] {
  background-color: #4CAF50;
  border: none;
  color: white;
 font-size: 22px;
  
  margin: 4px 2px;
  cursor: pointer;
}

.button{
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 font-size: 16px;
 margin: 4px 2px;
 color:green;
 cursor: pointer;
 border-radius:20px;
}
.button2:hover {
    cursor: pointer;
    background: red;
color:white;        
animation-name: example;
animation-duration: 10s;
animation-iteration-count: infinite;
 }
.button2{ 
    border: none;
    outline: none;
	font-family: "Times New Roman", Times, serif;
 text-align: center;
 font-size: 18px;
 background-color: green;
 cursor: pointer;
 width:80%;
 height: 60px;
 margin-bottom: 5px;
 border-radius:30px;
 color:white;
}

.button1 {
  color: green;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}
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
    text-align: center;
    font-size: 25px;
}

.mydatagrid
{
top:15%;
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
     <hr class="line1"/>
			<h1 class="popular1">Payment Details</h1><br/>
   
    
			 <bold class="container" style="color:green">Here is your Seat Information:</bold> 
             <asp:GridView ID="GridView1" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" runat="server" >
                    </asp:GridView>
              <Center><div style="top:13%;left:50%; position:fixed; background-color:green;color:red; font-weight: bold;border-radius:0px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
			<br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
                        <strong class="detail">Payment:</strong><br/>
                         <br/>
                         <br/>
               <div class="container">
                         
                    <asp:Button ID="Done" class="button2" Text="Pay The Ticket" OnClick= "Directing" runat="server" />
                   </div>
</asp:Content>
