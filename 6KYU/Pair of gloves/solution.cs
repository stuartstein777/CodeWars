using System.Linq;
using System;

public class Kata {
  public static int NumberOfPairs(string[] gloves) {
    var grps = gloves.GroupBy(x => x);
    var pairs = 0;
    foreach(var g in grps)
    {
      pairs += g.Count() / 2;
    }
      
    return pairs;
  }
}