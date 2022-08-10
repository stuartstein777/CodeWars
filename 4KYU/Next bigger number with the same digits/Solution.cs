using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        var digits = n.ToDigits().ToArray();
        var d = -1;

        for (var i = digits.Length-2; i >= 0; i--)
        {
            if (digits[i] >= digits[i + 1])
                continue;
            d = i;
            break;
        }

        if (d == -1)
            return -1;

        var smallestLargerThanToSwap = 9;
        var e = d+1;
        for (var i = d+1; i < digits.Length; i++)
        {
            //$"Looking at {digits[i]}".Dump();
            if (digits[i] <= digits[d] || digits[i] > digits[e])
                continue;

            smallestLargerThanToSwap = digits[i];
            e = i;
        }
        (digits[d], digits[e]) = (digits[e], digits[d]);
        return digits.Take(d+1).Concat(digits.Skip(d+1).OrderBy(c => c)).ToArray().ToNumber();
    }
}

public static class CodeWarExtensions
{
    public static IEnumerable<int> ToDigits(this long n)
        => n.ToString().ToCharArray().Select(c => int.Parse(c.ToString()));
  
    public static long ToNumber(this int[] digits)
        => long.Parse(string.Join("", digits));
}
