using System;
using System.Collections.Generic;
using System.Linq;
public class Sum
{
	public int GetSum(int a, int b)
	{
		Console.WriteLine($"{a} {b}");
		var total = 0;
		var range = GetRange(a, b);
		for(var i = range.Start; i <= range.End; i++)
			total+= i;
		return total;
	}
     
	public (int Start, int End) GetRange(int a, int b)
		=> (a > b)
			   ? (b, a)
			   : (a, b);
}