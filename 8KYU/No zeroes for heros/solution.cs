using System;

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
       => n == 0
             ? 0
             : int.Parse(n.ToString().TrimEnd('0'));
}