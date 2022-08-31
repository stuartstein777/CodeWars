public class Recursion
{
  public static ulong Factorial(ulong n)
  {
    checked
    {
      if(n == 0)
        return 1;
      return n * Factorial(n - 1);    
    }
  }
}