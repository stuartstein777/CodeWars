Copy to clipboardusing System;

public static class Kata
{
  public static string Encrypt(string text, int rule)
  {
       var res = "";
    
       foreach(var c in text)
       {
            var e = ((int)c + rule) % 256;
            res += ((char)e).ToString();
       }
    
       return res;
  }
}