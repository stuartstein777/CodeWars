using System;
using System.Linq;
public class Kata
{
	public static int CountBits(int n)
		=> Convert.ToString(n, 2).Count(c => c == '1');
}