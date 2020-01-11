using System;
public static class Kata
{
	public static long rowSumOddNumbers(long n)
	{	
		var last = (n * n) + (n - 1);
		var start = last - (2 * (n -1));
		return ((start + last) / 2) * n; 
	}
}