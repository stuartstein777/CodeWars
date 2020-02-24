namespace smile67Kata
{
    using System;
    using System.Linq;
    public class Kata 
    {
        private string Rev(string s)
          => string.Join("", s.ToCharArray().Reverse());  

        public string reverseAndCombineText(string s)
        {  
            var splits = s.Split(' ');
            return (splits.Length == 1)
               ? s
               : reverseAndCombineText(string.Join(" ", splits.Select(c => Rev(c))
                                             .Select((c, i) => i % 2 == 0
													? i + 1 == splits.Count() 
														? c
														: c + Rev(splits[i + 1])
													: null)
                                             .Where(c => c != null)));
        }
    }
}