using System;
using System.Collections.Generic;
public class Ghost
{
  public static Dictionary<int, string> _colors = new Dictionary<int, string>
              {
                {1, "white"},
                {2, "yellow"},
                {3, "purple"},
                {4, "red"}
              };
    private readonly string _color;
    
    public Ghost()
      => _color = _colors[new Random().Next(1, 5)];
    
    public string GetColor() => _color;
}