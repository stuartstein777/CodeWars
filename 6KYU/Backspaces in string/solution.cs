public class Kata
{
  public static string CleanString(string s)
  {
    var a = s.ToCharArray();
    var result = string.Empty;
    var charsToSkip = 0;  
    for(int i = a.Length-1;  i >= 0; i--)
    {
      if(a[i] == '#')
        charsToSkip ++;
      else
      {
        if(charsToSkip > 0)
          charsToSkip --;
        else
          result = a[i].ToString() + result;
      }    
    }
    return result;
  }
}