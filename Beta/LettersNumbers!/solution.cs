using System.Linq;
public static class Kata
{
  public static string ZerosCount(string s)
  {
    var result = s.Split(' ')
                  .Select(c => (c, c.ToCharArray().Where(x => x == '0').Count()))
                  .OrderByDescending(c => c.Item2)
                  .Take(1)
                  .First();
    return result.Item2 > 0 ? $"{result.Item1} has {result.Item2} Zeros!"
                            : "No Zero Found!";
  }   
}