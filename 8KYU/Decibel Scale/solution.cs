using System;

public static class Kata
{
	public static double DbScale(double intensity)
		=> 10 * Math.Log10(intensity / Math.Pow(10, -12));
}