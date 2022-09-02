using System;
using System.Linq;

public class Dinglemouse
{
    private static string GetHistogramBar((int N, int Percentage) percentages, int total)
  {
    var h = $"{percentages.N}|";
    h += string.Join("", Enumerable.Repeat("█", (int)Math.Floor(percentages.Percentage/2.0)));
    if(percentages.Percentage > 0)
      h+= $" {percentages.Percentage}%";
    return h;
  }

  private static (int n, int Percentage) GetPercentage(int i, int idx, int totalRolls)
  {
    if(totalRolls == 0)
      return (idx+1, 0);
    return (idx+1, (int)Math.Floor(i/(double)totalRolls*100));
  }
  public static string Histogram(int[] results)
  {
      var totalRolls = results.Sum();
      return string.Join("\n", results.Select((i, idx) => GetPercentage(i, idx, totalRolls))
                                      .Select(i => GetHistogramBar(i, totalRolls))
                                      .Reverse()) +"\n";

  }
}