using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    private static bool IsSenior(int[] memberInfo) => memberInfo[0] >= 55 && memberInfo[1] > 7;
    public static IEnumerable<string> OpenOrSenior(int[][] data)
        => data.Select(d => IsSenior(d) ? "Senior" : "Open");
}