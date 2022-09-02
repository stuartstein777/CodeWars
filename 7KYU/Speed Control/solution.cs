using System;
using System.Linq;
public class GpsSpeed {
    
    public static int Gps(int s, double[] x)
    {
        var max = 0.0;
        for(int i = 1; i < x.Length; i++)
        {
          var cmax = ((x[i] - x[i-1])/s) * 3600;
          if(cmax > max)
            max = cmax;
        }
        return (int)Math.Floor(max);
    }
}