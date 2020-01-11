public class Kata
{
	public static bool AmIWilson(int p)
	{
		double n = (Factorial(p - 1) + 1.0) / (p * p);
		return n == (int)n;
	}
  
	private static int Factorial(int p)
	{
		var f = 1;
		for(int i = 1; i <= p; i++)
			f*=i;
		return f;
	}
}