using System;

public class Kata
{
	public static string Problem(String a)
		=> (double.TryParse(a, out var y))
				? ((y * 50)+6).ToString()
				: "Error";
}