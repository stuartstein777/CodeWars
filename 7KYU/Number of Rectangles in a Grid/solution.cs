public class Grid {
  public static int NumberOfRectangles(int m, int n)
    => (((m+1) * m) / 2) * (((n+1) * n) / 2);
}