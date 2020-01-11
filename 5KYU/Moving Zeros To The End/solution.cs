using System.Linq;
public class Kata
{
	public static int[] MoveZeroes(int[] arr)
	{
		var result = arr.Where(i => i != 0).ToList();
		result.AddRange(Enumerable.Repeat(0, arr.Length - result.Count));
		return result.ToArray();
	}
}