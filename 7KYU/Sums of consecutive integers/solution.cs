using System.Linq;
public class SumOfConsecutiveIntegers
{
    public static int Position(int x, int y, int n)
    {
        var r = x * (x + 1)/2;
        return Enumerable.Range((y - r) / x,x).ToArray()[n] +1;
    }
}