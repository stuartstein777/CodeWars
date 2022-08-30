using System;
using System.Linq;
public class Kata
{
  public static String[] LineupStudents(String a)
     => a.Split(' ')
         .OrderByDescending(s => s.Length)
         .ThenByDescending(s => s)
         .ToArray();
}