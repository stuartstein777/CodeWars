using System;
using System.Linq;
public static class Kata
{
  public static int MaxGap(int[] numbers)
  {
    var sorted = numbers.OrderBy(c => c).ToList();
    return numbers.OrderBy(c => c)
                  .SkipLast(1)
                  .Select((s, i) => sorted[i+1] - s)
                  .Max();
  }
}