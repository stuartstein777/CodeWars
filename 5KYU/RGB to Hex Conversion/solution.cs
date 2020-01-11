public class Kata
{
	public static string Rgb(int r, int g, int b) 
	{
		r = Clamp(0, 255, r);
		g = Clamp(0, 255, g);
		b = Clamp(0, 255, b);
    
		return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
	}
	public static int Clamp(int min, int max, int val)
		=> val < min ? min : val > max ? max :val;
}