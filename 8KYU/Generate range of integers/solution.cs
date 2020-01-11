using System.Collections.Generic;
public class Kata
{
	public static int[] GenerateRange(int min, int max, int step)
	{
		var result = new List<int>();
		for (var i = min; i <= max; i += step)
		  result.Add(i);
		return result.ToArray();
	}
}