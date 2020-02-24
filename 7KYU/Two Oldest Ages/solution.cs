using System.Linq;
public class LargestTwo
{
  public static int[] TwoOldestAges(int[] ages)
    => ages.OrderByDescending(c => c).Take(2).OrderBy(c => c).ToArray();
}