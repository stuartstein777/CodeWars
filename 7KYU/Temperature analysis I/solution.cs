using System.Linq;

public class Kata
{
  public static int? LowestTemperature(string t)
  {
    if(string.IsNullOrEmpty(t))
      return null;
    
    return t.Split(' ').Select(c => int.Parse(c.ToString())).Min();
  }
}