using System.Linq;

public class Kata
{
  private static string MiddleNameInitials(string[] names)
    => string.Join(" ", names.Skip(1).Take(names.Count() - 2).Select(c => c[0] + "."));

  public static string InitializeNames(string name)
  {
      var names = name.Split(' ');
      return names.Count() switch
      {
          1 => name,
          2 => name,
          _ => $"{names[0]} {MiddleNameInitials(names)} {names.Last()}"
      };
   }
}