using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
    =>(on + wait <= cap)
        ? 0
        : wait - (cap - on);
}