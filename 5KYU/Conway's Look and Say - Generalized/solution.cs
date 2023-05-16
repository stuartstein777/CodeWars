using System;
using System.Collections.Generic;

public static class Kata
{
  private static int[] NumberToDigits(ulong n)
  {
    var digits = new List<int>();
    while (n != 0)
    {
        digits.Insert(0, (int)(n % 10));
        n /= 10;
    }
    return digits.ToArray();
  }
  
  private static ulong Partition(IReadOnlyList<int> xs)
  {
    var n = xs[0];
    var c = 1;
    ulong result = 0;
    for (var i = 1; i < xs.Count; i++)
    {
        var x = xs[i];
        if (x == n)
        {
            c++;
        }
        else
        {
            if (result != 0)
                result *= 100;
            
            result += (ulong)(c * 10);
            result += (ulong)n;
            n = x;
            c = 1;
        }
    }
    result *= 100;
    result += (ulong)(c * 10);
    result += (ulong)n;
    return result;
  }
  
  public static ulong LookSay(ulong number)
  {
    if(number == 0) return 10ul;
    var digits = NumberToDigits(number);
    return Partition(digits);
  }
}