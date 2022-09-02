using System;
using System.Linq;
class Kata
{
    public static int NthSmallest(int[] arr, int pos)
    {
        return arr.OrderBy(a => a).ToArray()[pos-1];
    }
}