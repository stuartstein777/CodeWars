using System;
public class Kata 
{
  public static int BreakChocolate(int n, int m) 
     => (n == 0 || m == 0)  ? 0 : n *m - 1;
}