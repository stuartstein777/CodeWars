using System;
public class Kata
{
	public static int SumDigits(int number)
	{
		number = Math.Abs(number);
		var total = 0;
		while(number > 0)
		{
			total += (number % 10);
			number = number / 10;
		}
		return total;
	}
}