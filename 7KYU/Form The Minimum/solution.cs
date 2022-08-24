using System.Linq;
class Kata
{
    public static long MinValue(int[] xs)
        =>int.Parse(xs.Distinct()
                      .OrderBy(a => a)
                      .Aggregate("", (acc, i) => acc + i.ToString()));
}