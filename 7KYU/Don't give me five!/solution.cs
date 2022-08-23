using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
    private static bool ContainsFive(int n)
    {
        while (n != 0)
        {
            if (Math.Abs(n % 10) == 5)
                return true;
            n /= 10;
        }
        return false;
    }
    
    public static int DontGiveMeFive(int start, int end)
        => Enumerable.Range(start, (end - start) + 1)
                     .Count(n => !ContainsFive(n));
}