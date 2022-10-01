using System;
using System.Linq;

public class Solution
{
    private static (int, int) GetIndexOfNLargestItems(int[] xs, int n)
    {
        if (xs[0] >= xs[2] && xs[1] >= xs[2])
            return (0, 1);
        else if (xs[0] >= xs[1] && xs[2] >= xs[1])
            return (0, 2);
        else
            return (1, 2);
    }

    private static bool CanPlay(int[] xs)
        => xs.Count(x => x > 0) >= 2;
    
    public static int solve(int [] xs)
    {  
        var daysPlayed = 0;
        while (CanPlay(xs))
        {
            var (a, b) = GetIndexOfNLargestItems(xs, 2);
            xs[a]--;
            xs[b]--;
            daysPlayed++;
        }
        return daysPlayed;
    }
}