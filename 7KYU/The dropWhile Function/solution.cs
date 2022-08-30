using System;
using System.Linq;
public class Kata
{
    public static int[] DropWhile(int[] arr, Func<int, bool> pred)
      => arr.SkipWhile(pred).ToArray();
}