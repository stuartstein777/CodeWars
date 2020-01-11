using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static int GetUnique(IEnumerable<int> numbers)
	{
		var sorted = numbers.OrderByDescending(i => i);
		var sub = sorted.Take(2).ToList();
		sub.Add(sorted.Last());
		return sub[0] != sub[1]
		        ? sub[0]
		        : sub[2];
	}
}