using System;
public class Kata
{
  private static bool last = false;
  
  public static bool omnibool
  {
    get
    {
      last = !last;
      return last;
    }
  }
}