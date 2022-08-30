using System;
using System.Linq;

public class Kata
{
    public static int DivCon(Object[] xs)
        => xs.Aggregate(0, (acc, i) => i is int i1 ? acc + i1 : acc - int.Parse(i.ToString()));

    public static bool IsInteger(object o)
        => o is int ? true : false;
}