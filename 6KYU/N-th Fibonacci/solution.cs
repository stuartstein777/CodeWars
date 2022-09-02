using System;
public class Fibonacci
{
  public int NthFib(int n)
    => (int) Math.Round(Math.Pow((1 + Math.Sqrt(5)) / 2, n-1) / Math.Sqrt(5));  
}
