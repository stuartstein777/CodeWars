namespace Solution
{
  using System.Linq;
  public static class Program
  {
    public static string repeatStr(int n, string s)
      => string.Concat(Enumerable.Repeat(s, n));
  }
}