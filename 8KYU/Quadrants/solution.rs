fn quadrant(x: i32, y: i32) -> i32 {
    if(x > 0 && y > 0) {
        return 1;
    }
    if(x < 0 && y > 0) {
        return 2;
    }
    if(x < 0 && y < 0) {
        return 3;
    }
    return 4;
}