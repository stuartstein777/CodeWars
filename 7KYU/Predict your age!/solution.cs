using System;
using System.Linq;

public class Predicter
{
    public static int PredictAge(params int[] ages)
      => (int)Math.Sqrt(ages.Select(a => a*a).Sum()) / 2;
}