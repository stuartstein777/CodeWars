public class Kata
{
  public static int SecondSymbol(string s, char c)
  {
      var occurrences = 0;
      for (var i = 0; i < s.Length; i++)
      {
          if(s[i] == c)
              occurrences++;
          if (occurrences == 2)
              return i;
      }
      return -1;   
  }
}