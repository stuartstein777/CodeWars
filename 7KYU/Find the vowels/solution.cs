using System.Collections.Generic;
using System;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    var vowelIndices = new List<int>();
    var lowered = word.ToLower();
    for(var i = 0; i < word.Length; i++)
    {
      if(IsVowel(lowered[i]))
        vowelIndices.Add(i+1);
    }
    return vowelIndices.ToArray();
  }
  
  public static bool IsVowel(char c)
   => c == 'a' ||
      c == 'e' ||
      c == 'i' ||
      c == 'o' ||
      c == 'u' ||
      c == 'y';
}