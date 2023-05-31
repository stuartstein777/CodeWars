using System;
using System.Collections.Generic;
using System.Text;
public static class Kata
{
    public static string OddLadder(int n)
    {
        var res = new List<string>();
        for (var i = 1; i <= n; i += 2)
        {
            var sb = new StringBuilder();
            for (var j = 0; j < i; j++)
            {
                sb.Append($"{i}");
            }
            res.Add(sb.ToString());            
        }

        return string.Join("\n", res);
    }
}