
using System.Linq;
using System;
using System.Collections.Generic;
public static class Puzzle
{
  
  private static List<string> DrawEvenTile(int m)
  {
    return new List<string>()
    {
        " " + string.Join("", Enumerable.Repeat("|_     ", m)) + "|_",
      " " + string.Join("", Enumerable.Repeat(" _) _  ", m)) + " _)",
    };
  }


  private static List<string> DrawOddTile(int m)
  {
    return new List<string>()
    {
      " " + string.Join("", Enumerable.Repeat("_|     ", m)) + "_|",
      "" + string.Join("", Enumerable.Repeat("(_   _ ", m)) + "(_",
    };
  }
  
  public static string PuzzleTiles(int n, int m)
  {
    List<string> img = new();
    img.Add("   " + string.Join(" ", Enumerable.Repeat("_( )__", n)));
    for(var i = 1; i <= m; i++)
    {
      if(i % 2 == 0)
        img.AddRange(DrawEvenTile(n));
      else
        img.AddRange(DrawOddTile(n));

      img.Add(" |" + string.Join("|", Enumerable.Repeat("__( )_", n)) + "|");
    }

    return string.Join("\n", img);
  }
}