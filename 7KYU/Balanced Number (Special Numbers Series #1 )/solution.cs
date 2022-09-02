using System.Linq;
using System;
class Kata
{
    public static string BalancedNumber(int number)
    {
      var l = number.ToString().Length;
      var digits = number.ToString().Select(d => (int) Char.GetNumericValue(d));
      int left;
      int right;

      if (l % 2 != 0)
      {
        var m = (int) Math.Ceiling(number.ToString().Length / 2.0);
        left = digits.Take(m - 1).Sum();
        right = digits.Skip(m).Sum();
      }
      else
      {
        var m = number.ToString().Length / 2;
        left = digits.Take(m - 1).Sum();
        right = digits.Skip(m + 1).Sum();
      }

      if (left == right)
        return "Balanced";
      return "Not Balanced";
    }
}