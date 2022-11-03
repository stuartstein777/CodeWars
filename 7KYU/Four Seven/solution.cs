using System.Collections.Generic;
public class Kata
{
  public static int FourSeven(int num)
  {
    var vals = new Dictionary<int, int>
    {
         {4, 7},
         {7, 4}
    };
    var x = 0;
    vals.TryGetValue(num, out x);
    return x;
  }
}