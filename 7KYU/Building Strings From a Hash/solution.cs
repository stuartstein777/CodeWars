using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
    => string.Join(",", hash.Select(kv => $"{kv.Key} = {kv.Value}"));
}