using System;
using System.Collections.Generic;
using System.Linq;

public class Dinglemouse
{
  public static int KookaCounter(string laughing)
     =>  laughing.Where((c, idx) => idx % 2 == 0 )
                 .PartitionBy(char.IsUpper)
                 .Count();
}

public static class CodeWarExtensions
{
     public static IEnumerable<IEnumerable<T>> PartitionBy<T>(this IEnumerable<T> xs, Func<T, bool> f)
    {
        if (!xs.Any())
          return new List<IEnumerable<T>>();

        var result = new List<IEnumerable<T>>();
        var last = f(xs.First());
        var partition = new List<T> { xs.First() };

        for (var i = 1; i < xs.Count(); i++)
        {
            var x = xs.ElementAt(i);
            var fx = f(x);
            if (fx == last)
                partition.Add(x);
            else
            {
                result.Add(partition);
                partition = new List<T> { x };
                last = fx;
            }
        }

        result.Add(partition);
        return result;
    }
}