using System;

public static class Kata
{
  public static int NearestSq(int n)
  {
       var sqrtFloor = (int)Math.Floor(Math.Sqrt(n));
       var sqrtCeil = (int)Math.Ceiling(Math.Sqrt(n));

       sqrtFloor *= sqrtFloor;
       sqrtCeil *= sqrtCeil;
    
       return (Math.Abs(sqrtFloor - n) > Math.Abs(sqrtCeil - n))
         ? sqrtCeil
         : sqrtFloor;
  }
}