using System;
using System.Collections.Generic;
using System.Linq;
public class Dinglemouse
{
    public static double GetRange(int a, int b, int c)
    {
        double ad = a;
        double bd = b;
        double cd = c;
        
        return Math.Max(ad, Math.Max(bd, cd)) - Math.Min(ad, Math.Min(bd, cd));
    }

    public static bool AllHaveSameParity(int a, int b, int c)
    {
        return (a % 2 == 0 && b % 2 == 0 && c % 2 == 0) || (a % 2 != 0 && b % 2 != 0 && c % 2 != 0);
    }
    
    public static int[] ThreeAmigos(int[] numbers)
    {
        Console.WriteLine(string.Join(",", numbers));
        double smallestRange = double.MaxValue;
        var currentBest = new List<int>();
        
        for (var i = 0; i < numbers.Length-2; i += 1)
        {
            int a = numbers[i];
            int b = numbers[i + 1];
            int c = numbers[i + 2];

            if (!AllHaveSameParity(a, b, c))
                continue;

            var range = GetRange(a, b, c);  
            if (range < smallestRange)
            {
                smallestRange = range;
                currentBest = new List<int> { a, b, c };
            }
        }
        
        return currentBest.ToArray();
    }
}