using System;
using System.Collections.Generic;
using System.Linq;
namespace Kata
{
  public static class Kata
{
    public static int[] UpArray(int[] digits)
    {
        if(!digits.Any() || digits.Any(n => n > 9 || n < 0))
            return null;
        var pos = digits.Length - 1;

        while (pos >= 0)
        {
            digits[pos]++;
            if (digits[pos] == 10)
            {
                digits[pos] = 0;
                pos--;
            }
            else
                break;
        }

        if (pos == -1 && digits[0] == 0)
        {
            var x = digits.ToList();
            x.Insert(0, 1);
            return x.ToArray();
        }
        return digits;
    }
}

}