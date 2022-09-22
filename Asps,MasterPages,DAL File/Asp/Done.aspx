<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="Done.aspx.cs" Inherits="project.Done" %>
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
}
.button2{ 
 padding: 10px 20px;
 text-align: center;
 font-size: 16px;
 cursor: pointer;
 color:green;
}

.button1 {
  color: green;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}


</style>

    <hr class="line1"/>
			<h1 class="popular1">Confirmation</h1><br/>
                     <strong class="detail">Thank You...... :)</strong><br/>
			 <strong class="detail">Your tickets have been confirmed..... :)</strong><br/>
			 <strong class="detail">Have a Safe Journey...... :)</strong><br/>
                         <br/>
                         <br/>
              <div class="container">
                
			</div>


</asp:Content>
