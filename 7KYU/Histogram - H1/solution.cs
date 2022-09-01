using System.Linq;
public class Dinglemouse 
{
// results to dictionary keyed on n, Count(n)
  public static string Histogram(int[] results)
  {
    return string.Join("\n", results.Reverse()
                                    .Select((r, i) => $"{6-i}|{string.Concat(Enumerable.Repeat("#", r))}{GetEndCount(r)}")) + "\n";
  }
  
  public static string GetEndCount(int r)
  {
    if(r == 0)
      return "";
    else
      return $" {r}";
  }
}