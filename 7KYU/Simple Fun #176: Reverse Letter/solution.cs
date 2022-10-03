namespace myjinxin
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
  
    public class Kata
    {
        public string ReverseLetter(string str){
          return string.Join("", Regex.Replace(str, "[^A-Za-z]", "").Reverse());
        }
    }
}