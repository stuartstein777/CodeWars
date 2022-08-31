using System.Linq;
class Kata
{
    public static int[] ProductArray(int[] xs)
      => xs.Select((_, ix) => xs.Where((t, i) => i != ix).Aggregate(1, (current, t) => current * t)).ToArray();
}