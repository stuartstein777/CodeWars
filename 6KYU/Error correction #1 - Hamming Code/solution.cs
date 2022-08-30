using System.Collections.Generic;
using System;
using System.Linq;

public class CodeWars
{
    private static char MostCommonBit(IEnumerable<char> xs)
    {
        if (xs.ElementAt(0) == xs.ElementAt(1))
            return xs.ElementAt(0);
        if (xs.ElementAt(0) == xs.ElementAt(2))
            return xs.ElementAt(0);
        return xs.ElementAt(1);
    }
    public static string Encode(string text)
        => string.Join("", text.Select(c => (short)c)
                               .SelectMany(n => Convert.ToString(n, 2).PadLeft(8, '0'))
                               .SelectMany(n => Enumerable.Repeat(n, 3)));

    public static string Decode(string bits)
        => string.Join("",
                       bits.ToCharArray()
                           .Partition(3)
                           .Select(MostCommonBit)
                           .Partition(8)
                           .Select(c => string.Join("", c))
                           .Select(c => (char)Convert.ToInt32(c, 2)));

}

static class Extensions
{
    public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> xs, int partitionSize)
    {
        var result = new List<IEnumerable<T>>();
        var cnt = xs.Count();
        for (var i = 0; i < xs.Count(); i += partitionSize)
        {
            var toTake = i + partitionSize > cnt ? (cnt - i) : partitionSize;
            result.Add(xs.Skip(i).Take(toTake));
        }
        return result;
    }  
}