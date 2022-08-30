using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
    public static bool Narcissistic(int value)
    {
        var digits = IntToDigits(value);
        var pow = digits.Count();

        var n = digits.Select(d => Math.Pow(d, pow)).Sum();

        return n == value;
    }

    public static IEnumerable<int> IntToDigits(int n)
    {
        var xs = new List<int>();

        while (n != 0)
        {
            xs.Add(n % 10);
            n /= 10;
        }
        
        return xs;
    }
}