using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
      var sqrt = Math.Sqrt(n);
      return (n - (Math.Floor(sqrt)  * Math.Floor(sqrt)) == 0)
        ? true
        : false;
  }
}