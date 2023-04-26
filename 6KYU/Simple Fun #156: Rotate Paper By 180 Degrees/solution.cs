namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
    public class Kata
    {
        public bool RotatePaper(string s)
        {
            Console.WriteLine(s);
            return IsBasicallySymmetrical(s) && AreSixesAndNinesInStringSymmetrical(s);    
        }
  
        bool AreSixesAndNinesInStringSymmetrical(string number)
        {
            if (number.Contains("6") || number.Contains("9"))
            {
                var indexesOfSixes = AllIndexesOf(number, "6").ToHashSet();
                var indexesOfNines = AllIndexesOf(ReverseStr(number), "9").ToHashSet();
                return !indexesOfNines.Except(indexesOfSixes).Any() && indexesOfSixes.Count == indexesOfNines.Count;
            }
            else
            {
                return true;
            }
        }

        bool IsBasicallySymmetrical(string number)
        {
            return number.All(a => a is '8' or '0' or '5' or '6' or '9' or '2');
        }
      
        string ReverseStr(string s) => string.Join("", s.ToCharArray().Reverse());
      
        public static IEnumerable<int> AllIndexesOf(string str, string searchstring)
        {
            var minIndex = str.IndexOf(searchstring);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length);
            }
        }
    }
}