using System;
using System.Linq;
using System.Collections.Generic;
public class Tournament
{
    public static (List<int>, List<int>) Rotate(List<int> xs, List<int> ys)
    {
        var xsr = new List<int>();
        var ysr = new List<int>();

        xsr.Add(xs[0]);
        xsr.Add(ys[0]);

        for (var i = 1; i <= xs.Count - 2; i++)
            xsr.Add(xs[i]);

        for (var i = 1; i <= xs.Count - 1; i++)
            ysr.Add(ys[i]);

        ysr.Add(xs[^1]);

        return (xsr, ysr);
    }

    public static (int, int)[] GetRoundMatchups(List<int> xs, List<int> ys)
        => xs.Select((x, i) => (x, ys[i])).ToArray();

    public static (int, int)[][] BuildMatchesTable(int numberOfTeams)
    {
        List<int> xs = new();
        List<int> ys = new();

        for (var i = 0; i < numberOfTeams / 2; i++)
        {
            xs.Add(i + 1);
            ys.Add(numberOfTeams - i);
        }

        List<(int, int)[]> rounds = new();

        // get each round.
        for (var i = 0; i < numberOfTeams - 1; i++)
        {
            rounds.Add(GetRoundMatchups(xs, ys));
            (xs, ys) = Rotate(xs, ys);
        }

        return rounds.ToArray();
    }
}