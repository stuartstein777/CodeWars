using System;
public class Triangular
{
    public bool isTriangular(int t)
    {
        var sol = (Math.Sqrt((1 + (8 * t))) - 1) * 0.5;
        return sol == Math.Floor(sol);
    }
}