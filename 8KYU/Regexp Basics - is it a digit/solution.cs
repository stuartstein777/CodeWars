using System;
using System.Text;
using System.Text.RegularExpressions;
public static class Kata
{
	public static bool Digit(this string s) => s.Length <= 1 && !string.IsNullOrEmpty(s) && "0123456789".Contains(s);
}