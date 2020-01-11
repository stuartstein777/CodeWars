using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static bool IsIsogram(string str) 
	{
		if(str == "")
			return true;
   
		str = str.ToLower();
		var counts = new Dictionary<char, int>();

		for(int i = 0; i < str.Length; i++)
		{
			if (counts.ContainsKey(str[i]))
				counts[str[i]]++;
			else
				counts.Add(str[i], 1);
		}
		var max = counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
		return max == 1;
	}
}