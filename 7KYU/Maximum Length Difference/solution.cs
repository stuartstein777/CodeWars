using System;
using System.Linq;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        if(a1.Length == 0 || a2.Length == 0)
            return -1;
        var a1Max = a1.Select(s => s.Length).Max();
        var a1Min = a1.Select(s => s.Length).Min();
        var a2Min = a2.Select(s => s.Length).Min();
        var a2Max = a2.Select(s => s.Length).Max();

        var a1MaxMinusA2Min = Math.Abs(a1Max - a2Min);
        var a2MaxMinusA1Min = Math.Abs(a1Min - a2Max);
        return Math.Max(a1MaxMinusA2Min, a2MaxMinusA1Min);
    }
}