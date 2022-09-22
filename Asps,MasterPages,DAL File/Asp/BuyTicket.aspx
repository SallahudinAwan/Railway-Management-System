<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="BuyTicket.aspx.cs" Inherits="Railways.Asps.BuyTicket"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="icon" href="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" type="image/x-icon"/>
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
.button{
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 font-size: 16px;
 margin: 4px 2px;
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
  border-radius:20px;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}


.button3
{
    border: none;
    outline: none;
	font-family: "Times New Roman", Times, serif;
    height: 40px;
	margin-bottom: 10px;
    background-color: green;
    width:30%;
    color: white;
    position:fixed;
    top:23%;
    left:40%;
    font-size: 18px;
    border-radius: 30px;
	
}
.button3:hover
{
    cursor: pointer;
    background: red;
    color: white;
	animation-name: example;
  animation-duration: 10s;
  animation-iteration-count: infinite;
}


    </style>
        <hr class="line1"/>
			<h1 class="popular1">Buy Ticket</h1>
   
      <br/><br/><br/>
   <strong class="detail">Select your Journey:</strong><br/>
     <br/>
    
    <div class="container">
        
        <br/><br/>
        <label style="color:green" for="departure">Departure:</label>
            <label style="color:green" for="Departure1">From Station:</label> 
            <asp:DropDownList ID="FromStation" class="button button1" runat="server">
            <asp:ListItem Text="--Select--" Value="0"></asp:ListItem>
             <asp:ListItem Text="Faislabad" Value="FSD"></asp:ListItem>
             <asp:ListItem Text="Lahore" Value="LHR"></asp:ListItem>
              <asp:ListItem Text="Karachi" Value="KHI"></asp:ListItem>
              </asp:DropDownList>
            <br/><br/>
            <label style="color:green" for="Departure2">To Station:</label> 
            <asp:DropDownList ID="ToStation" class="button button1" runat="server">
            <asp:ListItem Text="--Select--" Value="0"></asp:ListItem>
             <asp:ListItem Text="Faislabad" Value="FSD"></asp:ListItem>
             <asp:ListItem Text="Lahore" Value="LHR"></asp:ListItem>
              <asp:ListItem Text="Karachi" Value="KHI"></asp:ListItem>
              </asp:DropDownList>
			<br/><br/>
            <asp:Button ID="SeatSearch" class="button3" OnClick="Button1_Click" Text="Search Seat" runat="server" />
			</div>

</asp:Content>
