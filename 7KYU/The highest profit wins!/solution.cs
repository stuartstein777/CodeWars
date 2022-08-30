using System;
using System.Linq;
public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {
        var sorted = lst.OrderBy(c => c);
        return new[]{sorted.First(), sorted.Last()}; 
    }
}