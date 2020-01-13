using System;
public static class Kata
{
	public static ulong OddCount(ulong n)
		=> n % 2 == 0 ? (n / 2) : (n - 1) / 2;
}