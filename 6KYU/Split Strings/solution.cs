using System.Linq;
public class SplitString
{  
  public static string[] Solution(string str)
  {
    var splits = str.ToCharArray();
    var results = splits.Where((_, i) => i % 2 == 0).Zip(splits.Where((_, i) => i % 2!= 0), (a, b) => $"{a}{b}").ToList();
    if (splits.Count() % 2 != 0)
      results.Add($"{str.Last()}_");
    return results.ToArray();
  }
}