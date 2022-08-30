using System;
using System.Collections.Generic;
using System.Linq;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b)
    {
        var res = new List<long>();
        for (var n = a; n <= b; n++)
        {
            var digits = NumberToDigits(n);
            var sumDigPow = SumDigPow(digits);

            if (sumDigPow == n)
                res.Add(n);
        }
        return res.ToArray();
    }

    private static long SumDigPow(IEnumerable<int> digits)
        => digits.Select((n, idx) => (long)Math.Pow(n, idx+1)).Sum();

    private static IEnumerable<int> NumberToDigits(long n)
        => n.ToString()
            .Select(digit => int.Parse(digit.ToString()));
}