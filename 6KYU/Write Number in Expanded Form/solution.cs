
using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
		var digits = num.ToString().Length;
		long unit = 1L;
		var result = new List<string>();
		var n = num.ToString();
		for (var i = digits - 1; i >= 0; i--)
		{
			if (n[i] != '0')
				result.Insert(0, (int.Parse(n[i].ToString()) * unit).ToString());
			unit *= 10;
		}
		return string.Join(" + ", result);
   }
}