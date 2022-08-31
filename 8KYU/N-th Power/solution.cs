using System;
public class Kata
{
  public static double Index(int[] array, int n)
    => (n > array.Length-1)
              ? -1
              : Math.Pow(array[n], n);
}