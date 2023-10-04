using System;
using System.Collections.Generic;
using System.Linq;

public class Diamond
{
    private static string DrawRow(int length, int stars)
    {
        var sc = string.Join("", Enumerable.Repeat("*", stars));
        var padding = (length - stars) / 2;
        var pad = string.Join("", Enumerable.Repeat(" ", padding));
        var res = pad + sc;
        return res;
    }

    public static string print(int n)
    {
        if(n % 2 == 0 || n < 0) return null;
       
        var rows = new List<string>();
        
        for (var i = 1; i <= n; i+=2)
        {
            rows.Add(DrawRow(n, i));
        }

        for (var i = n - 2; i >= 1; i -= 2)
        {
            rows.Add(DrawRow(n, i));
        }
        return string.Join("\n", rows) + "\n";
    }
}