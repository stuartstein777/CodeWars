using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int[] Divisors(int n)
  {
      HashSet<int> res = new();
    
      for(var i = 2; i <= Math.Sqrt(n); i++)
      {
        if(n % i == 0)
        {
           res.Add(i);
           res.Add(n / i);
        }
      }
      return res.Any()
        ? res.OrderBy(c => c).ToArray()
        : null;
  }
}