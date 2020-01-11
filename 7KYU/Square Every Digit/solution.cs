using System;
using System.Linq;
public class Kata
{
    public static int SquareDigits(int n)
			=> int.Parse(n.ToString()
				          .Select(c => int.Parse(c.ToString()))
						  .Aggregate(string.Empty, (current, x) => current + x * x));
}