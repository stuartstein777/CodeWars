using System;
using System.Linq;
using System.Collections.Generic;
public class IQ
{
	public static int Test(string numbers)
	{ 
		var split = numbers.Split(' ').Select(c => int.Parse(c.ToString())).ToList();

		return (split.Count(c => c % 2 == 0) > split.Count(c => c % 2 != 0))
			? split.TakeWhile(c => c % 2 == 0).Count() + 1
			: split.TakeWhile(c => c % 2 != 0).Count() + 1;
	}
}