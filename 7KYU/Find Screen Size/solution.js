function findScreenHeight(width, ratio) {
    var x = ratio.split(":")[0];
    var y = ratio.split(":")[1]
    return width +"x"+((width * y) / x);
}