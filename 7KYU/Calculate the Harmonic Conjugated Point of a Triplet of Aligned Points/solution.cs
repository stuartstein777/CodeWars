using System;

public class HarmonicPoints
{
    
    public static double HarmPoints(double a, double b, double c)
      => Math.Round((((2.0 * a * b) - (a * c) - (b * c)) / (a + b - (2.0 * c))), 4);
}