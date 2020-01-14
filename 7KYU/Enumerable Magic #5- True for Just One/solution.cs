using System;
using System.Linq;
public class Kata
{
	public static bool One(int[] arr, Func<int, bool> fun)
		=> arr.Where(fun).Count() == 1;
}