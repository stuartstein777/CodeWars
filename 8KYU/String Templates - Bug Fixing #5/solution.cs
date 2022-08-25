using System;

public static class Kata 
{
    public static string buildString(string[] args)
      => $"I like {String.Join(", ", args)}!";
}