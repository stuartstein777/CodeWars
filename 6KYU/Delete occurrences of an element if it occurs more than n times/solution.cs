using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static int[] DeleteNth(int[] arr, int x)
	{
		var filtered = new List<int>();
		var counts = new Dictionary<int, int>();
		foreach(var a in arr)
		{
			counts.TryGetValue(a, out var currentCount);
			counts[a] = currentCount + 1;
			if(counts[a] <= x)
				filtered.Add(a);
		}
		return filtered.ToArray();
	}
}