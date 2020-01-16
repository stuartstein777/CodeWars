using System.Collections.Generic;
public class Kata
{
  private static Dictionary<string, string> _drinks = new Dictionary<string, string>
            {
              {"jabroni", "Patron Tequila"},
              {"school counselor", "Anything with Alcohol"},
              {"programmer", "Hipster Craft Beer"},
              {"bike gang member", "Moonshine"},
              {"politician", "Your tax dollars"},
              {"rapper", "Cristal"},
            };
  public static string GetDrinkByProfession(string p)
    => _drinks.ContainsKey(p.ToLower())
          ? _drinks[p.ToLower()]
          : "Beer";
}