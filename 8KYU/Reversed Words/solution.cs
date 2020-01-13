using System.Linq;
using System;
public class Kata
{
	public static string ReverseWords(string str)
		=> string.Join(" ", str.Split(' ').Reverse());
}