using System;
public class Kata
{
	public static double SquareArea(double A)
	{
		var sideLength = ((4 * A) / Math.PI) / 2;
		return Math.Round((sideLength * sideLength), 2);
	}
}