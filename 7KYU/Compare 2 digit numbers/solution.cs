using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string Compare(int a, int b)
    {
        var astr = a.ToString();
        var bstr = b.ToString();
        if(astr[0] == bstr[0] && astr[1] == bstr[1]) return "100%";
        if(astr[0] == bstr[0] && astr[1] != bstr[1]) return "50%";
        if(astr[0] != bstr[0] && astr[1] == bstr[1]) return "50%";
        if(astr[0] == bstr[1] && astr[1] == bstr[0]) return "100%";
        if (astr[0] != bstr[1] && astr[1] == bstr[0]) return "50%";
        if (astr[0] == bstr[1] && astr[1] != bstr[0]) return "50%";
        return "0%";
    }
  }
}