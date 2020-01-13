using System;
using System.Linq;
public class Kata
{
	public static bool Any(int[] arr, Func<int,bool> fun)
		=> arr.Any(fun);
}