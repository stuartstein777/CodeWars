using System.Linq;
public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    => YourPoints > ClassPoints.Average();
}