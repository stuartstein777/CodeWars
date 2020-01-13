using System;
using System.Text.RegularExpressions;
class Kata
{
	public static int StrCount(string str, string letter)
		=> Regex.Matches(str, $"{letter}").Count;
}