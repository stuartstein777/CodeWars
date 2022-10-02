namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Kata
    {
      public int SumGroups(int[] arr)
      {
          var xs = arr.AsEnumerable();
          while (true)
          {
              var parts = xs.PartitionBy(x => x % 2 == 0);
              if (parts.Any(x => x.Count() > 1))
                  xs = parts.Select(x => x.Sum());
              else
                  return xs.Count();
          }
       }
    }
  
    public static class CodewarExtensions
    {
      public static IEnumerable<IEnumerable<T>> PartitionBy<T>(this IEnumerable<T> xs, Func<T, bool> f)
      {
          var result = new List<IEnumerable<T>>();
          var cnt = xs.Count();
          var last = f(xs.First());
          var partition = new List<T>();
          partition.Add(xs.First());
  
          for (var i = 1; i < xs.Count(); i++)
          {
              var x = xs.ElementAt(i);
              var fx = f(x);
              if (f(x) == last)
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
}