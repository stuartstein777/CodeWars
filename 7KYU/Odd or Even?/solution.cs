using System.Linq;
public class Kata
{
  public static string OddOrEven(int[] array)
    => (array.Sum() % 2 == 0)
      ? "even"
      : "odd";
}