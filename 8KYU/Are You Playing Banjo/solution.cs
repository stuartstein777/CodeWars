using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
    => name.ToLower().StartsWith("r") 
        ? name + " plays banjo"
        : name + " does not play banjo";  
}