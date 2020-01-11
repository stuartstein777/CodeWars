using System;
using System.Linq;
public static class Kata
{
	public static int CountSheeps(bool[] sheeps)
		=> sheeps.Where(b => b == true).Count();
}