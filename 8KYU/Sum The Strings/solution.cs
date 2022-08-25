using System;
namespace Solution
{
  public static class Program
  {
    public static string StringsSum(string s1, string s2)
    {
      if(s1 == "" && s2 == "")
         return "0";
      else if(s1 == "")
         return s2;
      else if(s2 == "")
         return s1;
      else
         return $"{int.Parse(s1) + int.Parse(s2)}";
    }
  }
}