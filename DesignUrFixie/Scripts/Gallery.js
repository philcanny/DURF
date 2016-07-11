

var imagecount = 0;
var total = 3;

function slide(x) {
    var Image = document.getElementById('bike');
    imagecount = imagecount + x;
    Image.src = "~/Content/TestImages/img" + imagecount + ".png";
    alert(image.src);
}
