using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
public class Kata
{
  public static Int32 Calc(String s)
  {
    if(string.IsNullOrWhiteSpace(s))
      return 0;
    var total = string.Join("", s.ToCharArray().Select(c => (int)c));
    var total2 = total.Replace("7", "1");
    return BigInteger.Parse(total).ToDigits().Sum() -
           BigInteger.Parse(total2).ToDigits().Sum();
  }
}

public static class CodeWarExtensions
{
    public static IEnumerable<int> ToDigits(this BigInteger n)
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