namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public string ReplaceDashesAsOne(string input){
          var dashing = false;
          var res = "";
          for(var i = 0; i < input.Length; i++)
          {
              var c= input[i];
              if(c == '-')
              {
                 if(dashing) continue;
                 else
                 {
                    res += c.ToString();
                    dashing=true;
                 }
              }
              else if(c == ' ' &&
                      dashing &&
                      i != input.Length-1 &&
                      (input[i+1] == '-' || input[i+1] == ' ')) continue;
              else
              {
                  res += c.ToString();
                  dashing = false;
              }
          }
          return res;     
        }
    }
}