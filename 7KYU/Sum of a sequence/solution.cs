using System;
public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
    if(start > end) return 0;
    var n = ((end - start) / step) + 1;
    return (n * ((2*start) + ((n - 1) * step)))/2;
  }
}