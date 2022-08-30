using System;

public class VolTank
{
  public static int TankVol(int h, int d, int vt)
  {
       var r = d/2.0;
       var l = vt / (Math.PI * (r * r));
       return (int)Math.Floor(l * ((r * r) * Math.Acos((r - h) / r) - ((r - h) * Math.Sqrt((2 * r * h) - (h * h)))));
   }
}