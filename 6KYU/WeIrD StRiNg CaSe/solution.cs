using System;
using System.Linq;

public class Kata
{
  public static string ToWeirdCase(string s)
     => string.Join(' ',
            s.Split(' ')
             .Select(w => string.Join("", w.ToCharArray()
                                           .Select((c, idx) => idx % 2 == 0
                                                                ? char.ToUpper(c)
                                                                : char.ToLower(c)))));
}