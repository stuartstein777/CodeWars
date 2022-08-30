using System;

public static class Kata
{
    public static string Hello(string name)
       => string.IsNullOrEmpty(name)
              ? "Hello, World!"
              : $"Hello, {char.ToUpper(name[0]) + name.Substring(1).ToLower()}!";
  
    public static string Hello() => "Hello, World!";
}