using System.Linq;
using System.Collections.Generic;
public class LatinSquare
{
    public static int[][] MakeLatinSquare(int n)
    {
        var xs = Enumerable.Range(1, n);
        var res = new List<int[]>();
        for (var i = 0; i < n; i++)
        {
            var ys = xs.Skip(i).Concat(xs.Take(i)).ToArray();
            res.Add(ys);
        }
        return res.ToArray();
    }
}
