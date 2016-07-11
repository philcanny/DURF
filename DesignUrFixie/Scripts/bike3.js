

function setFrame(framechoice) {
    var frame = document.getElementById("FrameImage");

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

}

function setSaddle(saddlechoice) {
    var saddle = document.getElementById("SaddleImage");

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

}


function setHandlebar(handlebarchoice) {
    var handlebar = document.getElementById("HandlebarImage");

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
   
}

function setWheels(wheelschoice) {
    var wheels = document.getElementById("WheelsImage");

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
  
}



