using System.Numerics;
public class Spiral
{
    public static BigInteger Sum(BigInteger size)
    {
        var n = size-1;
        return n % 2 == 0
          ? n/2 * (n / 2 + 1) * 2 + 1 + n
          : (n + 1) / 2 * (n + 1) + n;
    }
}