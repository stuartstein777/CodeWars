using System;
using System.Collections.Generic;
using System.Linq;
public class FizzBuzz
{
	public static string[] GetFizzBuzzArray(int n)
	{
		if(n <= 0) throw new ArgumentOutOfRangeException();
		return Enumerable.Range(1, n)
						 .Select(Fizzbuzz)
						 .ToArray();
	}

	public static string Fizzbuzz(int n)
	{
		var result = "";
		if(n % 3 == 0)
			result += "Fizz";
		if(n % 5 == 0)
			result += "Buzz";
		return string.IsNullOrEmpty(result) ? n.ToString() : result;
	}
}