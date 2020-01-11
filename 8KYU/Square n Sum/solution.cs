using System.Linq;
public static class Kata
{
	public static int SquareSum(int[] n)
		=> n.Select(x => x * x).Sum();
}