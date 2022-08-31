using System.Linq;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
    => (a != null && b != null)
        ? b.OrderBy(x => x).SequenceEqual(a.Select(i => i*i).OrderBy(x => x))
        : false;
}