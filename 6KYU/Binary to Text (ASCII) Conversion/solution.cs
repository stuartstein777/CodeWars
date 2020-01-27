using System;
using System.Linq;
public static class Kata
{
	public static string BinaryToString(string binary)
	  => new string(Enumerable.Range(0, binary.Length / 8)
							  .Select(i => binary.Substring(i * 8, 8))
							  .Select(s => Convert.ToChar(Convert.ToInt32(s, 2))).ToArray());
}