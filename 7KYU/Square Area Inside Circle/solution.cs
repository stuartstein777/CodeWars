namespace Kata
{
	using System;
	public class Convert
	{
		public static double SquareAreaToCircle(double size)
		{
			var radius = Math.Sqrt(size) / 2;
			return Math.Round((Math.PI * (radius * radius)), 8);
		}
	}
}