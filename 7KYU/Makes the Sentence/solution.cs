using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool MakesTheSentence(List<char> characters, string sentence)
  {
      Console.WriteLine(sentence);
      Console.WriteLine(string.Join(",", characters));        
      var charsFreqs = characters.Frequencies();
      var sentenceFreqs = sentence.Replace(" ", "").ToCharArray().Frequencies();

      foreach (var (key, value) in sentenceFreqs)
        if (!charsFreqs.ContainsKey(key) || charsFreqs[key] != value)
            return false;
      return true;
  }
}

public static class CodewarExtensions
{
    public static Dictionary<T, int> Frequencies<T>(this IEnumerable<T> xs) where T : notnull
    {
        var res = new Dictionary<T, int>();
        foreach (var x in xs)
        {
            if (res.ContainsKey(x))
                res[x]++;
            else
                res.Add(x, 1);
        }
        return res;
    }
}