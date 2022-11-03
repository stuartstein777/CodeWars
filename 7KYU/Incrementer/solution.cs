using System.Linq;
public static class Kata
{
    public static int[] Incrementer(int[] numbers)
       => numbers.Select((n, ix) => (n + ix+1) % 10).ToArray();
}