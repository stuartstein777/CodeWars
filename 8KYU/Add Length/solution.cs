using System.Linq;
public class Kata
{
  public static string[] AddLength(string str)
     => str.Split(" ")
           .Select(x => $"{x} {x.Length}")
           .ToArray();
}