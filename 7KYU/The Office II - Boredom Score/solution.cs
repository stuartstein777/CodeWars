using System.Collections.Generic;
using System.Linq;

public class Kata
{

  private static int GetDepartmentBoredomAssessment(string name)
  {
      return name switch {
          "accounts" => 1,
          "finance" => 2,
          "canteen" => 10,
          "regulation" => 3,
          "trading" => 6,
          "change" => 6,
          "IS" => 8,
          "retail" => 5,
          "cleaning" => 4,
          "pissing about" => 25
      };
  }
  
  public static string Boredom(Dictionary<string, string> staff)
  {
      var boredomScore = 0;
    
      foreach(var kv in staff) {
        boredomScore += GetDepartmentBoredomAssessment(kv.Value);
      }
    
      if(boredomScore <= 80)
        return "kill me now";
      else if(boredomScore < 100)
        return "i can handle this";
      else
        return "party time!!";
  }

}