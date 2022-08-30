using System;
using System.Linq;
using System.Collections.Generic;
public class TwistedSum
{
  public static long Solution(long n)
     => CodewarsExtensions.CreateRange(1, n).Select(x => x.ToDigits().Sum()).Sum();
}

public static class CodewarsExtensions
{
  public static IEnumerable<long> CreateRange(long start, long count)
  {
      var limit = start + count;

      while (start < limit)
      {
          yield return start;
          start++;
      }
  }
  
  public static IEnumerable<int> ToDigits(this long n)
  {
     var res = new List<int>();
     while (n != 0)
     {
        res.Insert(0, (int)(n % 10));
        n /= 10;
     }
     return res;
  }  
}