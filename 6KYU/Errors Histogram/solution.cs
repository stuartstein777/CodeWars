using System;
using System.Linq;
public class Hist
{
  public static string hist(string s)
    =>string.Join("\r", s.ToCharArray()
                         .Where(c => c == 'u' || c == 'w' || c== 'x' || c == 'z')
                         .OrderBy(c => c)
                         .GroupBy(c => c)
                         .Select(grp => $"{grp.Key}  {grp.Count().ToString().PadRight(6)}{string.Join("", Enumerable.Repeat('*', grp.Count()))}"));
}