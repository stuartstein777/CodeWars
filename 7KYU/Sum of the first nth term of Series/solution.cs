using System;

public class NthSeries
{
	public static string seriesSum (int n)
	{
		if(n == 0)
			return "0.00";
      
		double start = 4;
		double total = 1;
		for(double i = 1; i < n; i++)
		{
			total += (1 / (double)start);
			start += 3;
		}
		return total.ToString(".00");
	}
}