using System;
using System.Linq;
public class Kata
{
	public static int PositiveSum(int[] arr)
		=> arr.Where(n => n > 0).Sum();
}
