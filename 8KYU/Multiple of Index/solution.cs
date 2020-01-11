using System;
using System.Collections.Generic;
public static class Kata
{
	public static List<int> MultipleOfIndex(List<int> xs)
	{
		var result = new List<int>();
		for (var i = 1; i < xs.Count; i++)
			if (xs[i] % i == 0)
				result.Add(xs[i]);

		return result;
	}
}