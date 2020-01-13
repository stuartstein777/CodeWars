using System;
using System.Linq;
public class Kata
{
	public static long StairsIn20(int[][] stairs)
		=> stairs.Select(c => c.Sum()).Sum() * 20;
}