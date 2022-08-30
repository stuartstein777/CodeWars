using System;
using System.Collections.Generic;
using System.Linq;

public class Persist 
{
    public static int Persistence(long n)
    {
        var c = 0;
        while(true)
        {
            if (n < 10)
                return c;
            c++;
            var digits = n.ToDigits();
            var p = digits.Aggregate(1, (acc, i) => acc * i);
            if (n == p)
                return c;
            n = p;
        }
    }
}

public static class Extensions
{
    public static IEnumerable<int> ToDigits(this long n)
    {
        var res = new List<int>();

        while ((int)n != 0)
        {
            res.Insert(0, (int)n % 10);
            n /= 10;
        }
        
        return res;
    }
}