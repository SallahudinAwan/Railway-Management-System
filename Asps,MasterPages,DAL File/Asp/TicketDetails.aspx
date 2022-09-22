<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="TicketDetails.aspx.cs" Inherits="Railways.Asp.TicketDetails" %>
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
  top:5%;
   left:10%;
  text-align:center;
  padding: 0px 350px 0px 300px;
  cursor: pointer;
  font-size: 18px;
}
.container1 {
  color:green;
  position: relative;
  top:10%;
   left:10%;
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
  padding: 16px 32px;
  margin: 4px 2px;
  cursor: pointer;
}

.button{
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 font-size: 16px;
 margin: 4px 2px;
 border-radius:20px;
 cursor: pointer;
}
.button2{ 
 padding: 10px 20px;
 text-align: center;
 font-size: 16px;
 cursor: pointer;
 
 border-radius:20px;
 color:green;
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
.button2:hover {
background-color:brown;
color:white;        
        
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
.popular2{
	font-family: "Times New Roman", Times, serif;
	text-decoration-line: none;
    text-decoration-style: solid;
	color:white;
    margin: 10px;
	position:fixed;
	 top: 27.5%;
    left: 50%;
    text-align: center;
    font-size: 25px;
}

</style>

  <hr class="line1"/>
			<h1 class="popular1">Train Information</h1><br/>
           <div class="container">
    <label style="color:green" for="Train">Enter the Ticket Number, you need Details</label>
    <br />
                    <asp:TextBox ID="SelTrain" class="button button1" type="text" name="R"  runat="server" >
                    </asp:TextBox>
					<br/><br/><br/>
     <asp:Button ID="SearchDeTails" class="button2 " OnClick="Button1_Click" Text="Search Details" runat="server" />
		<br/><br/><br/>
           </div>	
     <h1 class="popular2">Delete Ticket</h1><br/>
    <div class="container1">
        <hr class="line1" style="left:0%;width:100%;"/>
        <h1 class="popular2">Delete Ticket</h1><br/>
    <Center><div style="left:20%; background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
    <label style="color:green" for="Train">Enter the Ticket Number, you Want to Delete</label>
    <br />
               
                           <asp:TextBox ID="delticket" class="button button1" type="text" name="R"  runat="server" >
                    </asp:TextBox>
					<br/><br/><br/>
     <asp:Button ID="deltick" class="button2" OnClick="deletetrain" Text="Delete Ticket" runat="server" />
</div>
</asp:Content>
