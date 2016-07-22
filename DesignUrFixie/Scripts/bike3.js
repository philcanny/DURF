/*var gframe = "";
var gsaddle = "";
var ghandlebar = "";
var gwheels = "";*/



function setFrame(framechoice) {
    var frame = document.getElementById("FrameImage");
    var frameC = document.getElementById("FrameColour").value=framechoice;

    if (framechoice === 'Black') {
        framecolor = '<img src="/Content/Images/BlackFrame.png" class="img-responsive">'
    }
    else if (framechoice === 'Red') {
        framecolor = '<img src="/Content/Images/RedFrame.png" class="img-responsive">'
    }
    else if (framechoice === 'Green') {
        framecolor = '<img src="/Content/Images/GreenFrame.png" class="img-responsive">'
    };

    frame.innerHTML = framecolor;
    frameC.innerHTML = framechoice;
    gframe = framechoice;
}

function setSaddle(saddlechoice) {
    var saddle = document.getElementById("SaddleImage");
    var frameC = document.getElementById("SaddleColour").value = saddlechoice;

    if (saddlechoice === 'Black') {
        saddlecolor = '<img src="/Content/Images/BlackSaddle.png" class="img-responsive">'
    }
    else if (saddlechoice === 'Red') {
        saddlecolor = '<img src="/Content/Images/RedSaddle.png" class="img-responsive">'
    }
    else if (saddlechoice === 'Green') {
        saddlecolor = '<img src="/Content/Images/GreenSaddle.png" class="img-responsive">'
    };

    saddle.innerHTML = saddlecolor;
    saddleC.innerHTML = saddlechoice;
    gsaddle = saddlechoice;
}


function setHandlebar(handlebarchoice) {
    var handlebar = document.getElementById("HandlebarImage");
    var frameC = document.getElementById("HandlebarColour").value = handlebarchoice;

    if (handlebarchoice === 'Black') {
        handlebarcolor = '<img src="/Content/Images/BlackHandlebar.png" class="img-responsive">'
    }
    else if (handlebarchoice === 'Red') {
        handlebarcolor = '<img src="/Content/Images/RedHandlebar.png" class="img-responsive">'
    }
    else if (handlebarchoice === 'Green') {
        handlebarcolor = '<img src="/Content/Images/GreenHandlebar.png" class="img-responsive">'
    };

    handlebar.innerHTML = handlebarcolor;
    handlebarC.innerHTML = handlebarchoice;
    ghandlebar = handlebarchoice;
}

function setWheels(wheelschoice) {
    var wheels = document.getElementById("WheelsImage");
    var frameC = document.getElementById("WheelColour").value = wheelschoice;

    if (wheelschoice === 'Black') {
        wheelscolor = '<img src="/Content/Images/BlackWheels.png" class="img-responsive">'
    }
    else if (wheelschoice === 'Red') {
        wheelscolor = '<img src="/Content/Images/RedWheels.png" class="img-responsive">'
    }
    else if (wheelschoice === 'Green') {
        wheelscolor = '<img src="/Content/Images/GreenWheels.png" class="img-responsive">'
    };

    wheels.innerHTML = wheelscolor;
    wheelC.innerHTML = wheelschoice;
    gwheels = wheelschoice;
    
}

/* submit button validates that 

a) you are logged in        
        is user logged in? if yes proceed if not redirect to login screen....
b) you have pick one of each option         
        if item is not selected generate a message asking to select an option for that item

on reload of page previous choices are to be erased?

if logged in and choices are made it will
1) calls the getchoices function and 
2) Generates bike instance 
3) sets values to bike instance.
(validation may have to be in the getchoices function TBC)

generate order_id
get login_id from session and pass it to customer_id 
(or set login_id equal customer_id somehow....from login data

*/

function getchoices() {
    alert("Your Bike selections are as Follows\n" + "Frame: " + gframe + "\n" + "Saddle: " + gsaddle + "\n" + "Handbars: " + ghandlebar + "\n" + "Wheels: " + gwheels);
}
function YourBike() {
    alert("Your Designed Bike will have the following components\n" + "Frame: " + gframe + "\n" + "Saddle: " + gsaddle + "\n" + "Handbars: " + ghandlebar + "\n" + "Wheels: " + gwheels);
}

/*  possible code to write to the db based on the choices.... 
if (gframe === 'Black') {
         write to instance of a bike frame_Id = 1;
    }
    else if (gframe === 'Red') {
        /* write to instance of a bike frame_Id = 2;
    }
    else if (gframe === 'Green') {
       /* write to instance of a bike frame_Id = 3;
    }; 
    repeat each option for each part....when I have it figured out.
    
    */




