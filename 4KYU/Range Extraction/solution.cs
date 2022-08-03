using System;
using System.Collections.Generic;
using System.Linq;
public class RangeExtraction
{
    private static string RangeToString(List<int> currentRange)
    {
        if (currentRange.Count >= 3)
            return currentRange[0] + "-" + currentRange.Last();
        else
            return string.Join(",", currentRange);
    }

    public static string Extract(int[] xs)
    {
        var res = new List<string>();
        var last = xs[0];
        var currentRange = new List<int>{last};
      
        foreach (var n in xs.Skip(1))
        {
            if (n == last + 1)
                currentRange.Add(n);
            else
            {
                res.Add(RangeToString(currentRange));
                currentRange.Clear();
                currentRange.Add(n);
            }
            last = n;
        }

        res.Add(RangeToString(currentRange));
        return string.Join(",", res);
    }
}