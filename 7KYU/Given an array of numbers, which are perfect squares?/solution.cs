using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
    private static bool IsPerfectSquare(int x) => Math.Sqrt(x) % 1 == 0;

    public static int[] GetSquares(int[] array) {
        return array.Where(IsPerfectSquare).Distinct().OrderBy(c => c).ToArray();
    }
}