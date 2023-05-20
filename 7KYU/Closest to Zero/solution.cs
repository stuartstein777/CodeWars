using System;
using System.Linq;
public class Kata
{
  public static int? Closest(int[] arr)
  {
    var s = arr.OrderBy(a => Math.Abs(a)).ToArray();
    
    if(s[0] == 0) return 0;
    if(s[0] + s[1] == 0) return null;
    return s[0];    
  }
}