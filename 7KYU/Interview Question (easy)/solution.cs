using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
public class Kata
{
   public static string GetStrings(string city)
   {
      var characterCounts = new Dictionary<char, int>();
      foreach (var c in city.ToLower().Replace(" ", ""))
         if (characterCounts.ContainsKey(c))
            characterCounts[c]++;
         else
            characterCounts.Add(c, 1);
      return characterCounts.Aggregate(new StringBuilder(),
                                       (sb, kvp) => sb.Append($"{kvp.Key}:{string.Concat(Enumerable.Repeat("*", kvp.Value))},"),
                                        sb => sb.ToString().TrimEnd(','));
    }
}