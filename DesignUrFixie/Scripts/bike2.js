/*var blackFrame = false;
var redFrame = false;
var greenFrame = false;
var blackSaddle = false;
var redSaddle = false;
var greenSaddle = false;*/
/*function bycolour(colour) { 
    if (colour == 'blackFrame')
        {var blackFrame = true;}
    else 
        {var blackFrame = false;}
    
    if (colour == 'redFrame')
        {var redFrame = true;}
    else 
        {var redFrame = false;}
    
    if (colour == 'greenFrame')
        {var greenFrame = true;}
    else 
        {var greenFrame = false;}
}*/

var xyz = "good";

function setBlackFrame(x) {
    localStorage.setItem("frame", "/Content/Images/BlackFrame.png"); 
    var frame = document.getElementById("FrameImage");
    var framecolour = frame.innerHTML;
    frame.innerHTML = '<img src="/Content/Images/BlackFrame.png">';
    var mike = xyz;

    }

function setRedFrame(x) {
 
    localStorage.setItem("frame", "/Content/Images/RedFrame.png");
    var frame = document.getElementById("FrameImage");
    var framecolour = frame.innerHTML;
    frame.innerHTML = '<img src="/Content/Images/RedFrame.png">';
    }

function setGreenFrame(x) {
   
    localStorage.setItem("frame", "/Content/Images/GreenFrame.png");
    var frame = document.getElementById("FrameImage");
    var framecolour = frame.innerHTML;
    frame.innerHTML = '<img src="/Content/Images/GreenFrame.png">';
    }

function setBlackSaddle(x) {
    localStorage.setItem("saddle", "/Content/Images/BlackSaddle.png");
    var saddle = document.getElementById("SaddleImage");
    var saddlecolour = saddle.innerHTML;
    saddle.innerHTML = '<img src="/Content/Images/BlackSaddle.png">';
    }

function setRedSaddle(x) {
    localStorage.setItem("saddle", "/Content/Images/RedSaddle.png");
    var saddle = document.getElementById("SaddleImage");
    var saddlecolour = saddle.innerHTML;
    saddle.innerHTML = '<img src="/Content/Images/RedSaddle.png">';
    }

function setGreenSaddle(x) {
    localStorage.setItem("saddle", "/Content/Images/GreenSaddle.png");
    var saddle = document.getElementById("SaddleImage");
    var saddlecolour = saddle.innerHTML;
    saddle.innerHTML = '<img src="/Content/Images/GreenSaddle.png">';
    }


/*function Bike() {
        if (blackFrame === true) 
            {finalframe.innerHTML = '<img src="BlackFrame.png">';}
    
        else if (redFrame === true) 
            {finalframe.innerHTML = '<img src="RedFrame.png">';}
    
        else if (greenFrame === true) 
            {finalframe.innerHTML = '<img src="GreenFrame.png">';}
    
    
        if (blackSaddle === true) 
            {finalsaddle.innerHTML = '<img src="BlackSaddle.png">';}
    
        else if (redSaddle === true )
            {finalsaddle.innerHTML = '<img src="RedSaddle.png">';}
    
        else if (greenSaddle === true )
            {finalsaddle.innerHTML = '<img src="GreenSaddle.png">'; }
    
}*/

//calling the function with setTimeout to make sure the HTML is loaded
//setTimeout(setFrameImage, 500);