using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static string GoodVsEvil(string good, string evil)
    {
		Console.WriteLine("Good: " + good);
		Console.WriteLine("Evil: " + evil);
		var goodGuys = new Dictionary<int, int> {{0, 1}, {1, 2}, {2, 3}, {3, 3}, {4, 4}, {5, 10}};
		var evilGuys = new Dictionary<int, int> {{0, 1}, {1, 2}, {2, 2}, {3, 2}, {4, 3}, {5, 5}, {6, 10}};
		var goodValues = good.Split(' ').Select(int.Parse);
		var evilValues = evil.Split(' ').Select(int.Parse);

		var totalGood = 0;
		var totalEvil = 0;
		var i = 0;
		foreach (var g in goodValues)
		{
			totalGood += goodGuys[i] * g;
			i++;
		}

		i = 0;
		foreach (var e in evilValues)
		{
			totalEvil += evilGuys[i] * e;
			i++;
		}
		if (totalGood == totalEvil)
			return "Battle Result: No victor on this battle field";
		return totalGood < totalEvil
			? "Battle Result: Evil eradicates all trace of Good"
			: "Battle Result: Good triumphs over Evil";
    }
}