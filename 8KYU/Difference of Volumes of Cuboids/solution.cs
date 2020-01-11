using System.Linq;
public class Kata
{
	public static int FindDifference(int[] a, int[] b)
	{ 
		var vola = a.Aggregate(1, (acc, val) => acc * val);
		var volb = b.Aggregate(1, (acc, val) => acc * val);

		return (vola > volb)
				  ? vola - volb
				  : volb - vola;
	}
}