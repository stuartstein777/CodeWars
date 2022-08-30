using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
  private static int ClosestNeighbour(IEnumerable<int> xs, int idx)
  {
      var cnt = xs.Count();
      if (idx == 0)
          return Math.Abs(xs.ElementAt(1) - xs.ElementAt(idx));

      if(idx == cnt - 1)
        return Math.Abs(xs.ElementAt(idx) - xs.ElementAt(cnt - 2));

      return Math.Min(Math.Abs(xs.ElementAt(idx) - xs.ElementAt(idx-1)),
                      Math.Abs(xs.ElementAt(idx) - xs.ElementAt(idx+1)));        
  }
  
  public static bool IsNice(int[] arr)
  {
     var sortedArr = arr.OrderBy(a => a).Distinct();
    
     if(sortedArr.Count() < 2)
        return false;
    
     return sortedArr.Select((_, idx) => ClosestNeighbour(sortedArr, idx))
                     .All(n => n == 1);
  }
}