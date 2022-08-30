function distanceBetweenPoints(a, b) {
    var deltaX = Math.abs(a.x - b.x);
    var deltaY = Math.abs(a.y - b.y);
    return Math.sqrt((deltaX * deltaX) + (deltaY * deltaY));
}