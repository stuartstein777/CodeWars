using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
     var freqs = walk.Frequencies();
     return (freqs.GetValueOrDefault("e") == freqs.GetValueOrDefault("w") &&
             freqs.GetValueOrDefault("s") == freqs.GetValueOrDefault("n") &&
             walk.Length == 10);
  }
}

public static class CodeWarExtensions
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