using System;
namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
      => Math.Abs(((dadYears - sonYears) * 2) - dadYears);
  }
}