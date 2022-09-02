public class Slope
{

  public String slope(int[] points)
  {
    int deltaX = points[3] - points[1];
    int deltaY = points[2] - points[0];
    
    if(deltaY == 0)
      return "undefined";
    return Integer.toString(deltaX / deltaY);
  }

}