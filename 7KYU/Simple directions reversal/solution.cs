using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static string Swap(string dir)
    => dir == "Right" ? "Left" : "Right";

    public static string [] solve(string [] arr)
    {
      var directions = arr.Select(a => a.Split(" on "));
      var turns = new List<string>{"Begin"};
      turns.AddRange(directions.Select(x => x[0])
                               .Skip(1)
                               .Select(Swap)
                               .Reverse()
                               .ToList());
      var roads = directions.Select(x => x[1])
                            .Reverse();
      return roads.Zip(turns, (r, t) => t + " on " + r).ToArray();
    }
}