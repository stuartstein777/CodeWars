using System;
public class Kata
{
	public static int CalculateTip(double amount, string rating)
	{
		switch(rating.ToLower())
		{
		  case "excellent":
			return (int)Math.Ceiling(amount * 0.20D);
		  case "great":
			return (int)Math.Ceiling(amount * 0.15D);
		  case "good":
			return (int)Math.Ceiling(amount * 0.10D);
		  case "poor":
			return (int)Math.Ceiling(amount * 0.05D);
		  case "terrible":
			return 0;
		  default:
			return -1;
		}
	}
}