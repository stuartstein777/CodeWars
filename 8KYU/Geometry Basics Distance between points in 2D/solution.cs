using System;
public class Kata
{
  public static double DistanceBetweenPoints(Point a, Point b)
  {
    var deltaX = Math.Abs(a.X - b.X);
    var deltaY = Math.Abs(a.Y - b.Y);
    return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
  }
}