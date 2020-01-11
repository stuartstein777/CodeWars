using System.Linq;
using System;
public static class Kata
{
	// return masked string
	public static string Maskify(string cc)
	{
		if (cc.Length <= 4)
			return cc;
		var masked = string.Concat(Enumerable.Repeat("#", cc.Length - 4));
		return masked + cc.Substring(cc.Length - 4);
	}
}