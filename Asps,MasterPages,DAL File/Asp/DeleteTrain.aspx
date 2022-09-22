<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/AdminHome.Master" AutoEventWireup="true" CodeBehind="DeleteTrain.aspx.cs" Inherits="Railways.Asp.DeleteTrain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
.dropdown{
 background-color:white;
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 border-radius:5px;
 font-size: 14px;
 top:15%;
 left:30%;
 max-width:40%;
 position:fixed;
 margin: 10px 0px;
 cursor: pointer;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}
.delete {
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
.deletebutton
{
    border: none;
    font-family: "Times New Roman", Times, serif;
    outline: none;
    height: 30px;
    background-color:green;
    width:40%;
    left:30%;
    top:5%;
    position:relative;
    color: white;
    font-size: 18px;
    border-radius: 20px;
	
}.deletebutton:hover
{
    cursor: pointer;
    background-color:darkorange;
    color: WHITE;
	animation-name: example;
  animation-duration: 10s;
  animation-iteration-count: infinite;
}
    </style>
    <div>
    <asp:Label ID="Label1" CssClass="delete" style="position:fixed;top:12%;left:20%;" runat="server" Text="Remove Train"></asp:Label>
    <div style="position:fixed; top:14%;left:39%; background-color:#ffc107;color:red; font-weight: bold;border-radius:5px; font-size: 20px;color:white;" id="message" runat="server">
                     </div>
    <asp:DropDownList CssClass="dropdown"  ID="DropDownList1" runat="server" Width="100%">
    <asp:ListItem Value="--Train No"></asp:ListItem>  
</asp:DropDownList><br/>
    <asp:Button CssClass="deletebutton" style="top:18%;position:fixed;" ID="Button1" OnClick="deletetrain" runat="server" Text="Delete Train"/>
      <br/><br/><br/><br/><br/>
    <asp:Label ID="Label2" CssClass="delete" style="position:fixed;top:22%;left:20%;" runat="server" Text="Remove Station"></asp:Label>
    <div style="position:fixed; top:24%;left:39%; background-color:#ffc107;color:red; font-weight: bold;border-radius:5px; font-size: 20px;color:white;" id="message1" runat="server">
                     </div>
   <asp:DropDownList CssClass="dropdown" style="position:fixed;top:25%;"  ID="DropDownList2" runat="server" Width="100%">
    <asp:ListItem Value="--Train No"></asp:ListItem>  
</asp:DropDownList><br/>
    <asp:Button CssClass="deletebutton" style="top:28%;position:fixed;" ID="Button2" runat="server" OnClick="deletestation" Text="Delete Station"/>
      
         </div>

    
         <!-- </div>-->
</asp:Content>
