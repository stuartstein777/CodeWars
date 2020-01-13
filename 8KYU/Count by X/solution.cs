using System;

public static class Kata
{
	public static int[] CountBy(int x, int n)
	{
		var z = new int[n];
		for (var i = 1; i <= n; i ++)
			z[i-1] = (x * i);
		return z;
	}
}