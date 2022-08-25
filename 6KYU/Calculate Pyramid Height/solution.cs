using System;
public class Kata
{
  public static int PyramidHeight (int n)
  {
    var i = 0;
    do
    {
        i++;
        n -= i * i;
        if (n < 0)
            i--;

    } while (n > i * i);

    return i;
   }
}