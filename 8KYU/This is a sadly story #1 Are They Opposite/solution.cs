using System;
using System.Linq;
public class Kata
{
	public static bool IsOpposite(string s1, string s2)
		=> s1.Length == s2.Length &&
						s1 != "" &&
						s2 != "" &&
						!s1.Where((t, i) => char.IsLower(t) == char.IsLower(s2[i]) ||
											(char.ToLower(t) != char.ToLower(s2[i]))).Any();
}