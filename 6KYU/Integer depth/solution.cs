namespace Solution 
{
  using System.Linq;
  using System.Collections.Generic;
  public class Kata 
  {
    public static int[] NumberToDigits(int n)
    {
        var digits = new List<int>();
        while (n != 0)
        {
            digits.Insert(0, n % 10);
            n /= 10;
        }
        return digits.ToArray();
    }
    
    public static int ComputeDepth(int n)
    {
        var foundDigits = new HashSet<int>();
        var multiplier = 1;
        while (foundDigits.Count != 10)
        {
            foundDigits.UnionWith(NumberToDigits(n * multiplier));
            multiplier++;
        }
        return multiplier-1;
    }
  
  }
}