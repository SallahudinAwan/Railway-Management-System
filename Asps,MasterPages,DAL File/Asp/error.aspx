<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="Railways.Asps.error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error!!!</title>
     <style>
         *{
         background-color:red;       
         }
        .errtext {
    color:yellow;
    text-decoration-line: underline;
    font-size: 60px;
	font-family: "Times New Roman", Times, serif;
    text-decoration:dotted;
    text-align:center;
    width:50%;
    background: rgba(0,0,0,0.4);
    background-color:red;
    position:fixed;
    left:24%;
    top:70%;
}
         .button:hover {
         background-color:yellow;
         color:red;

         }
.button {
       border: none;
    outline: none;
    height: 50px;
    width:50%;
    background: white;
    color: green;
    font-size: 38px;
    border-radius: 20px;   
    position:fixed;   
    cursor:pointer;
     left:24%;
    top:85%;   
   }
         .image {
         
         
         }
    </style>
</head>
   
<body>
    <form id="form1" class="form1" runat="server">
        <center>
         <img class="image" style="width:90%; height:70%;" src="https://www.netclipart.com/pp/m/393-3932303_transparent-404-error-png.png"/>
           </center>
    <div class="errtext">

   Kindly Login First 
    </div>
  <asp:Button ID="Button1" CssClass="button" runat="server" Text="Login" OnClick="button_click"/>
       
    </form>
</body>
</html>
