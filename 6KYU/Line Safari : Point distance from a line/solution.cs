using System;
public class Dinglemouse
{
    public static double DistanceFromLine((int x, int y) a, (int x, int y) b, (int x, int y) c)
    {
      if (a.x == b.x && a.y == b.y)
        {
            var adj = Math.Abs(c.x - a.x);
            var opp = Math.Abs(c.y - a.y);
            return Math.Sqrt((adj * adj) + (opp * opp));
        }
     
        return 
            Math.Abs(((b.x - a.x) * (a.y - c.y)) - ((a.x - c.x) * (b.y - a.y)))
            /
            Math.Sqrt(((b.x - a.x) * (b.x - a.x)) + ((b.y - a.y) * (b.y - a.y)));
    }
}