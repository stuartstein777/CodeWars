using System.Collections.Generic;
using System;

public class Kata
{
  public static int OddOne(List<int> list)
    => Array.FindIndex(list.ToArray(), (int f) => f % 2 != 0);
}