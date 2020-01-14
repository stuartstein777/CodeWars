using System.Linq;
public static class Kata
{
	public static object[] RemoveEveryOther(object[] arr)
		=> arr.Where((_, i) => i % 2 == 0).ToArray();
}