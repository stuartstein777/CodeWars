using System;

public static class Kata
{
  public static double VectorLength(Vector2 vec)
  {
    var yDiff = Math.Abs(vec.Tail.Y - vec.Head.Y);
    var xDiff = Math.Abs(vec.Tail.X - vec.Head.X);
    
    return Math.Sqrt(yDiff * yDiff + xDiff * xDiff);
  }
}
