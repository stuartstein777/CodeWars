using System;
using System.Linq;
public class Kata
{
	public static string FindNeedle(object[] haystack)
	{
		for(int i = 0; i < haystack.Length; i++)
			if(haystack[i] != null && haystack[i].ToString().ToLower() == "needle")
				return $"found the needle at position {i}";
		return null;
	}
}