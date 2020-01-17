using System.Linq;
using System;
public class SequenceSum
{
  public static string ShowSequence(int n)
  {    
    if(n < 0)
      return $"{n}<0";
    else if(n == 0)
      return "0=0";
    else
    {
      var range = Enumerable.Range(0, n+1);
      var total = range.Sum();
      return string.Join("+", range) + $" = {total}";
    }
  }
}