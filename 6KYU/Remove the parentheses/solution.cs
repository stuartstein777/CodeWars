using System;
using System.Linq;
using System.Collections.Generic;
namespace Solution
{
  public static class Kata
  {
     public static string RemoveParentheses(string s)
    {
        var res = new List<char>();
        var opening = -1;
        var currentlyOpenedBrackets = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c == '(')
            {
                currentlyOpenedBrackets++;
                if (opening == -1)
                {
                    opening = i;
                }
            }
            else if (c == ')')
            {
                currentlyOpenedBrackets--;
            }
            else if (currentlyOpenedBrackets == 0)
            {
                res.Add(c);
                opening = -1;
            }
        }
        return string.Join("", res);
    }
  }
}