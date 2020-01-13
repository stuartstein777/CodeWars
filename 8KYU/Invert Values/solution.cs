using System.Linq;
namespace Solution
{
	public static class ArraysInversion
	{
		public static int[] InvertValues(int[] input)
			=> input.Select(i => -i).ToArray();
	}
}