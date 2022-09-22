<%@ Page Title="FeedBack" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="UserFeeback.aspx.cs" Inherits="Railways.Asps.UserFeeback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
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
    padding: 0px 0px 30px;
    text-align: center;
    font-size: 25px;
}
input select, textarea {
	font-family: "Times New Roman", Times, serif;
	font-weight:bold;
	font-size:20px;
  width: 70%; /* Full width */
  height:5%;
  padding: 5px; /* Some padding */ 
  border: 1px solid #ccc; /* Gray border */
  border-radius: 4px; /* Rounded borders */
  box-sizing: border-box; /* Make sure that padding and width stays in place */
  margin-top: 26px; /* Add a top margin */
  margin-bottom: 26px; /* Bottom margin */
  resize:horizontal; /* Allow the user to vertically resize the textarea (not horizontally) */
position:fixed;
top:13%;
left:26%;
}
.button1
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
    top:20%;
    left:40%;
    font-size: 18px;
    border-radius: 30px;
	
}
.button1:hover
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
			<h1 class="popular1">FeedBack</h1>
    <Center><div style="position:fixed;top:13%; left:50%; background-color:green;color:red; font-weight: bold;border-radius:0px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
    <textarea id="TextArea1" placeholder="Write something.." runat="server"></textarea>
    
     <asp:Button CssClass="button1" ID="Button1" runat="server" OnClick="Submit_Feedback" Text="Submit"/>
       
</asp:Content>
