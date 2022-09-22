<%@ Page Title="Add train" Language="C#" MasterPageFile="~/Master Pages/AdminHome.Master" AutoEventWireup="true" CodeBehind="Add Train.aspx.cs" Inherits="Railways.Asps.Add_Train" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="icon" href="https://0901.static.prezi.com/preview/v2/g52vvaj6if64i2k7zwaupamo6d6jc3sachvcdoaizecfr3dnitcq_3_0.png" type="image/x-icon"/>
    <link href="Addtrain.css" rel="stylesheet" />
    <style>
.loginbox{
    width: 920px;
    height:1810px;
    background: green;
    color:white;
    top: 90%;
    left: 75%;
    position: fixed;
    transform: translate(-50%,-50%);
    box-sizing: border-box;
    padding: 70px 30px;
	border-radius: 20px;
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
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
	
       <asp:Label ID="Label1" CssClass="Add" style="position:fixed;top:12%;left:20%;" runat="server" Text="Add Train"></asp:Label>
    
        <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message" runat="server">

                     </div></Center><br/>
        <center>
            
        <p>Train Name</p>
            <asp:TextBox ID="trainName" placeholder="Enter Train Name" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
           
            <p>Total Seats</p>
        <asp:TextBox ID="Seats" placeholder="Enter Total Seats" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>       
			</center>
			
        <asp:Button CssClass="addbutton" ID="Button1" runat="server" OnClick="AddTrain" Text="Add Train"/>
       <center><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
            <asp:Label ID="Label2" CssClass="Add" style="position:fixed;top:27%;left:20%;" runat="server" Text="Add Station"></asp:Label>
    <Center><div style="background-color:#ffc107;color:red; font-weight: bold;border-radius:10px; font-size: 16px;color:white;" id="message1" runat="server">
                     </div></Center><br/>
        <p>Station Name</p>
            <asp:TextBox ID="Station_Name" placeholder="Enter Station Name" AutoCompleteType="FirstName" runat="server" Width="447px">
               </asp:TextBox>
           <br/>
            <p>City</p>
        <asp:TextBox ID="City" placeholder="Enter City" AutoCompleteType="JobTitle" runat="server" Width="447px">
               </asp:TextBox>
           <br/>     
           </center>
    <asp:Button CssClass="addbutton"  ID="Button2" runat="server" OnClick="AddStation"  Text="Add Station"/>
			
			<br/>

</asp:Content>
