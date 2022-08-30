using System;
using System.Collections.Generic;
public static class Kata
{
  public static int MinDistance(int n)
  {
      var factors = new List<int>();
      for (var i = 1; i <= Math.Sqrt(n); i++)
      {
         if (n % i == 0)
         {
            factors.Add(i);
            if(n / i != i)
               factors.Add(n / i); // e.g. 25 would be 5 x 5, resulting in 5 twice, which means we get a min dist = 0
         }
      }
      factors.Sort();
      var smallest = int.MaxValue;
      for (var i = 0; i < factors.Count-1; i++)
      {
          var diff = factors[i + 1] - factors[i];
          if (diff < smallest)
              smallest = diff;
      }
      return smallest;
  }
}