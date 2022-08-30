public class Polygon {
    int sides;
    int sideLength;

    public Polygon(int sides, int sideLength) {
        this.sides = sides;
        this.sideLength = sideLength;
    }
    
    public double circleDiameter(){
        return 2 * sideLength / ((Math.tan(Math.toRadians(180.0 / sides))) * 2.0);
    }
}