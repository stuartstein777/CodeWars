using System;
public class Dinglemouse
{
    public static double StackHeight2d(int layers)
      =>  (layers == 0)
            ? 0d
            : Math.Sqrt(Math.Pow((layers-1.0), 2) - Math.Pow(((layers-1.0)/2.0), 2))+1.0;     
}