using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
	public static string ReverseWords(string str)
	{
		var split = str.Split(' ');
		var reversed = new List<string>();
		foreach (var arr in split.Select(s => s.ToCharArray()))
		{
			Array.Reverse(arr);
			var foo = new string(arr);
			reversed.Add(foo);
		}
		return string.Join(" ", reversed);
	}
}