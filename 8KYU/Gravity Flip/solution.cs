using System.Linq;
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
        => dir == 'L' ? arr.OrderByDescending(n => n).ToArray() : arr.OrderBy(n => n).ToArray();
}