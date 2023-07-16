enum quadrants {I=1, II, III, IV};

enum quadrants quadrant(int x, int y) {

    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    return 4;

}