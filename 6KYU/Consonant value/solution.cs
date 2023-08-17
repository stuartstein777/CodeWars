public class Kata
{
    private static bool IsVowel(char c)
       => c == 'a' || c == 'e' || c == 'i' || c =='o' || c=='u';
  
    public static int Solve(string s)
    {
        var largest = 0;
        var cur = 0;
      
        for(var i = 0; i < s.Length; i++)
        {
           if(IsVowel(s[i]))
           {
               if(cur > largest)
                  largest = cur;
                 
               cur = 0;
           }
           else
           {
               cur += s[i] - 96;
           }
        }
      
        return cur > largest ? cur : largest;
    }
}