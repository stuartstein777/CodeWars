using System;
using System.Linq;
using System.Text;

namespace Solution {
  public static class TIY {
   
   public static bool IsUppercaseVowel(char c)
     => c == 'A' || c =='E' || c == 'I' || c=='O' || c == 'U';
    
   public static bool IsLowercaseVowel(char c)
     => c == 'a' || c =='e' || c == 'i' || c=='o' || c == 'u';
    
   public static string FizzBuzz(string sentence)
    {
       var result = new StringBuilder();
     
       foreach(var c in sentence)
       {
            if(char.IsLetter(c)) {
                if(IsUppercaseVowel(c)) {
                  result.Append("Iron Yard");
                } else if(IsLowercaseVowel(c)) {
                  result.Append("Yard");
                } else if(char.IsUpper(c)) {
                  result.Append("Iron");
                } else {
                  result.Append(c.ToString());
                }
            } else {
              result.Append(c.ToString());
            }
       }
     
       return result.ToString();
    }
  }
}

