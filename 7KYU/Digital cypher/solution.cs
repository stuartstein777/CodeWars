using System;
using System.Collections.Generic;
using System.Linq;

public  class Kata
{
    public static int[] Encode(string str, int n)
    {
        Console.WriteLine($"str: {str}, n: {n}");
        var keyDigits = IntToDigits(n);
        return str.Select((c, idx) => c - 96 + keyDigits.ElementAt(idx % keyDigits.Count())).ToArray();
    }
    
    private static IEnumerable<int> IntToDigits(int n)
    {
        var xs = new List<int>();
        while (n != 0)
        {
            xs.Insert(0, n % 10);
            n /= 10;
        }
        return xs;
    }
}