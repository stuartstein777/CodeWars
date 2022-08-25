using System.Linq;

public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
        => new[]{a * (b + c),
                 a * (b * c),
                 a * b * c,
                 a + b + c,
                 (a + b) * c,
                 (a * b) * c,
                 (a * b) + c}.Max();
}