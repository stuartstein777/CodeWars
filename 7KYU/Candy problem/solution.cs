using System.Linq;
public class CandyProblem
{
	  public static int GetMissingCandies(int[] candies)
    {
        if(candies.Length <= 1) return -1;
        var max = candies.Max();
        return candies.Aggregate(0, (acc, i) => acc += max - i);
    }
}