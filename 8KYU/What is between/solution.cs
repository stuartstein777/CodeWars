using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
	public static int[] Between(int a, int b)
	{	
		var vals = new List<int>();
		for(int i = a; i <= b; i++)
			vals.Add(i);
		return vals.ToArray();    
	}
}