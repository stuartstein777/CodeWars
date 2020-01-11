using System.Linq;
public class Kata
{
	public static int[] Maps(int[] x)
		=> x.Select(i => i*2).ToArray();
}