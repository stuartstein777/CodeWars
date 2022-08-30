using System;
using System.Linq;

public static class Kata
{
    public static string MultiTable(int number)
       => string.Join("\n", Enumerable.Range(1, 10)
                                      .Select(n => $"{n} * {number} = {n * number}"));
}