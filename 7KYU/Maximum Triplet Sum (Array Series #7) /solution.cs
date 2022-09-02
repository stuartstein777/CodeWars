using System.Linq;
class Kata
{
    public static int MaxTriSum(int[] a)
      => a.Distinct()
          .OrderByDescending(c => c)
          .Take(3)
          .Sum();
}