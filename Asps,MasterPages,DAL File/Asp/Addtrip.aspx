<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/AdminHome.Master" AutoEventWireup="true" CodeBehind="Addtrip.aspx.cs" Inherits="Railways.Asp.Addtrip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Addtrain.css" rel="stylesheet" />
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
         .dropdown1{
 background-color:white;
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 border-radius:5px;
 font-size: 14px;
 top:18%;
 left:30%;
 max-width:40%;
 position:fixed;
 margin: 10px 0px;
 cursor: pointer;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}
          .dropdown2{
 background-color:white;
 border:solid; 
 padding: 10px 20px;
 text-align: center;
 border-radius:5px;
 font-size: 14px;
 top:21%;
 left:30%;
 max-width:40%;
 position:fixed;
 margin: 10px 0px;
 cursor: pointer;
  box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);
}
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
    <Center><div style="position:fixed;top:11%; left:40%;padding-left:20px;padding-right:20px; background-color:green;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">
                     </div></Center><br/>
         <asp:Label ID="Label1" CssClass="Add" style="position:fixed;top:12%;left:20%;" runat="server" Text="Add Trip"></asp:Label>
    <asp:Label ID="Label2" style="color:green;top:14%;left:30%;font-weight:bold; position:fixed;" runat="server" Text="Train No"></asp:Label>
    <div style="position:fixed;top:17%;left:30%;"> 
        
        <asp:DropDownList CssClass="dropdown"  ID="DropDownList1" runat="server" Width="100%">
    <asp:ListItem Value="--Train No"></asp:ListItem>  
</asp:DropDownList><br/>
    
        <p>Departure</p><br/><br/>
            <asp:DropDownList CssClass="dropdown1" style="max-width:38%; text-align:center;" ID="DropDownList2" runat="server" Width="100%">
              
              </asp:DropDownList>
           <br/>
			<p>Destination</p><br/><br/><br/>
            <asp:DropDownList CssClass="dropdown2" style="max-width:38%;" ID="DropDownList3" runat="server" Width="100%">
               
              </asp:DropDownList>
            
           <br/>    
        <p>Departure Date</p>
        <asp:TextBox ID="depdate" TextMode="DateTimeLocal" placeholder="Demo: 20210713 12:34:09 AM" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>  
         
         <p>Arrival Time</p>
        <asp:TextBox ID="arrtime" TextMode="DateTimeLocal" placeholder="Demo: 20210713 12:34:09 AM" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>    
             <p>Fare</p>
        <asp:TextBox ID="Fare" placeholder="Enter Fare" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>       
			</center>
		
        <asp:Button CssClass="addbutton" ID="Button1" runat="server" OnClick="AddTrip" Text="Add Trip"/>
       </div>

</asp:Content>
