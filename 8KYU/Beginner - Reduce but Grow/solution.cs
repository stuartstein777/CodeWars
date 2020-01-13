using System.Linq;
public class Kata
{
	public static int Grow(int[] x)
		=> x.Aggregate((i, acc) => acc *= i);
}