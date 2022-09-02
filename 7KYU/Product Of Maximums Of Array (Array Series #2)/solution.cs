using System.Linq;
public class Kata {
  public static int MaxProduct(int[] arr, int size)
  => arr.OrderByDescending(c => c)
      .Take(size)
      .Aggregate((acc, i) => acc * i);
}