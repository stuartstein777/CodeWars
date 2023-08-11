public class Kata
{
  public static string Vowel2Index(string str)
  {
     var res = "";
     for(int i = 0; i < str.Length; i++)
     {
         if("aeiouAEIOU".Contains(str[i]))
           res += i+1;
         else
          res += str[i];
     }
     return res;
  }
}