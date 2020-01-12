using System.Linq;
public class Kata
{
  public static int[] SortArray(int[] input)
  {
      var odds = input.Where(n => n % 2 != 0).OrderBy(c => c).ToArray();
      var oddCounter = 0;
      for (var i = 0; i < input.Length; i++)
      {
        if (input[i] % 2 != 0)
        {
          input[i] = odds[oddCounter];
          oddCounter++;
        }
      }
      return input;
  }
}