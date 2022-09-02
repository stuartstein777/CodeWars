using System;
public class Slope
{

  public String slope(int[] points)
  {
    var deltaX = points[3] - points[1];
    var deltaY = points[2] - points[0];
    
    if(deltaY == 0)
      return "undefined";
    return (deltaX / deltaY).ToString();
  }

}