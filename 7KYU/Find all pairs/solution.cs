using System.Collections.Generic;
using System.Linq;
using System;

class Kata
{
    public static int Duplicates(int[] a)
        => a.Frequencies()
            .Select(c => c.Value / 2)
            .Sum();
}

public static class CodewarExtensions
{
    public static Dictionary<T, int> Frequencies<T>(this IEnumerable<T> xs) where T : notnull
    {
        var res = new Dictionary<T, int>();
        foreach (var x in xs)
        {
            if (res.ContainsKey(x))
                res[x]++;
            else
                res.Add(x, 1);
        }
        return res;
    }
}