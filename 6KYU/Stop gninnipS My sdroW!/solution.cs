using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
    => string.Join(" ", sentence.Split(" ")
                                .Select(w => w.Length < 5 ? w : string.Join("", w.Reverse())));
}