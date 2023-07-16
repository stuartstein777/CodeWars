using System;

class PointView
{
	public static Func<int[]> Point(int a, int b)
	{
		  return () => new[]{a, b};
	}
	
  public static int Fst(Func<int[]> pt)
	{
		  return pt()[0];
	}
	
  public static int Snd(Func<int[]> pt)
	{
		  return pt()[1];
	}
	
  public static int SqrDist(Func<int[]> pt1, Func<int[]> pt2)
	{
    	var dx = Math.Abs(Fst(pt2) - Fst(pt1));
      var dy = Math.Abs(Snd(pt2) - Snd(pt1));
      return (dx * dx) + (dy * dy);
	}
  
	public static int[] Line(Func<int[]> pt1, Func<int[]> pt2) 
	{
	    return new[]
      {
         Snd(pt1) - Snd(pt2),
         Fst(pt2) - Fst(pt1),
         (Fst(pt1) * Snd(pt2)) - (Snd(pt1) * Fst(pt2))
      };
	}
}