<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/LoginHome.Master" AutoEventWireup="true" CodeBehind="loginHomePage.aspx.cs" Inherits="Railways.Asps.loginHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="loginHomePage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

.mySlides {display: none;}
.image {vertical-align: middle;}
/* Slideshow container */
.slideshow-container {
  max-width: 1000px;
  position: fixed;
  left:30%;
  top:43%;
  margin:auto;
}

/* Caption text */
.text {
    color:white;
    text-decoration-line: underline;
    font-size: 30px;
	font-family: "Times New Roman", Times, serif;
    text-decoration:dotted;
    text-align:center;
    width:90%;
    background: rgba(0,0,0,0.4);
    background-color:darkgreen;
  position: absolute;
  font-weight:400;
  font-size:50px;
  bottom: 0px;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}
.dot {
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}
</style>

    <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
			<iframe class="vid1" width="560" height="315" src="https://www.youtube.com/embed/gHCrHEJaYgk" frameborder="0" allowfullscreen></iframe>
			<br/><br/>
            <hr class="line1" style="position:fixed;top:30%;"/>
          
            <br/><br/>
			<h1 class="popular" style="position:fixed;top:32%;left:47%;">Popular Destination</h1>
            <br/>
            <img class="lahore" src="https://www.samaa.tv/wp-content/uploads/2017/01/minar-e-pakistan.jpg"/>
            <div class="lahoretext">Lahore</div>
           <img class="karachi" src="http://humansofpakistan.org/wp-content/uploads/2018/02/Mazar_View_at_night.jpg"/>
           <div class="karachitext">Karachi</div>
            <img class="fsd" src="https://trek.pk/wp-content/uploads/2020/06/Faisalabad.jpg"/>
            <div class="fsdtext">Faisalabad</div>
        
    
<div class="slideshow-container">

<div class="mySlides fade">
  <div class="numbertext">1 / 3</div>
  <img class="image" src="https://www.samaa.tv/wp-content/uploads/2017/01/minar-e-pakistan.jpg" style="width:90%;height:400px;"/>
   <div class="text" >Lahore</div>
</div>

<div class="mySlides fade">
  <div class="numbertext">2 / 3</div>
  <img class="image" src="http://humansofpakistan.org/wp-content/uploads/2018/02/Mazar_View_at_night.jpg" style="width:90%;height:400px;"/>
  <div class="text" >Karachi</div>
</div>

<div class="mySlides fade">
  <div class="numbertext">3 / 3</div>
  <img class="image" src="https://trek.pk/wp-content/uploads/2020/06/Faisalabad.jpg" style="width:90%;height:400px;"/>
  <div class="text">Faisalabad</div>
</div>

</div>
<br/>

<div style="text-align:center;">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
</div>

<script>
var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";  
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}    
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";  
  dots[slideIndex-1].className += " active";
  setTimeout(showSlides, 2000); // Change image every 2 seconds
}
</script>



</asp:Content>
