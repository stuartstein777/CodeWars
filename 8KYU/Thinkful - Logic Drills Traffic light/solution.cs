using System.Collections.Generic;

public class Kata
{
    public static string UpdateLight(string current)
        => new Dictionary<string, string>
           {
              { "green", "yellow" },
              { "yellow", "red" },
              { "red", "green" }
           }[current];
      
}