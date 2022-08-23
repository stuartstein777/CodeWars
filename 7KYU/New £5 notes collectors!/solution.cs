using System;
using System.Linq;
public class Kata
{
  public static int GetNewNotes(int salary, int[] bills)
    => Math.Max((salary - bills.Sum()) / 5, 0);
}