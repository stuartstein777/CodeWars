using System;
public static class MrSquare {
    public static bool FitSquares(int a, int b, int m, int n) {
        return a+b <= Math.Max(m,n) && Math.Max(a,b) <= Math.Min(m,n);
    }
}