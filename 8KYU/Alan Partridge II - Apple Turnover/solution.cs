public class Kata
{
	public static string Apple(object n)
	{
		int x = 0;
		if(n is int)
			x = (int)n;
		else
			x = int.Parse(n.ToString());
      
		if(x * x > 1000)
			return "It's hotter than the sun!!";
		else
			return "Help yourself to a honeycomb Yorkie for the glovebox.";
	}
}