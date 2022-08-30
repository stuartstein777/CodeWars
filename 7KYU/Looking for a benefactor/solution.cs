using System;
using System.Linq;
public class NewAverage
{
    public static long NewAvg(double[] arr, double navg)
    {
        var b = Math.Ceiling((arr.Length + 1) * navg
                         - arr.Sum());
      
      if (b < 0)
        throw new ArgumentException();
      return (long)b;
    }
}