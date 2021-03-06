using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
	public static string[] TowerBuilder(int n)
	{
		Console.WriteLine(n);
		var tower = new List<string>();
		for (var i = 0; i < n; i++)
		{
			var floor = string.Concat(Enumerable.Repeat(" ", (n - (i+1))));
			floor += string.Concat(Enumerable.Repeat("*", (i * 2) + 1));
			floor += string.Concat(Enumerable.Repeat(" ", (n - (i+1))));
			tower.Add(floor);
		}
		return tower.ToArray();
	}
}