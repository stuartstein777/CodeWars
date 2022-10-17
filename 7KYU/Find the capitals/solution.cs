using System;
using System.Collections.Generic;
public static class Kata
{
  public static int[] Capitals(string word)
  {
      var capitals = new List<int>();
    
      for(var i = 0; i < word.Length; i++)
      {
         if(char.IsUpper(word[i]))
            capitals.Add(i);
      }
      return capitals.ToArray();       
  }
}