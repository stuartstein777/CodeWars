public class Multiplier
{
	public static int Multiply(int x) 
		=> x % 2 == 0 
			? x * 8
			: x * 9;
} 