using System.Linq;
public class Kata
{
  public static int[] SortNumbers(int[] nums)
    => nums is null ? new int[0] : nums.OrderBy(c=>c).ToArray();
}