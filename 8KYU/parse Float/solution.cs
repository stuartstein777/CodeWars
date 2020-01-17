public class Kata
{
  public static double? ParseF(object s = null)
  {
    if(float.TryParse(s?.ToString(), out var f))
      return f;
    else
      return null;
  }
}