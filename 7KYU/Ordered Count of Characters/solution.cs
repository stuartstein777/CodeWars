using System;
using System.Collections.Generic;
using System.Linq;
namespace Solution
{
    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var frequencies = new Dictionary<char, int>();
            foreach(var c in input.ToCharArray())
                if(frequencies.ContainsKey(c))
                  frequencies[c]++;
                else
                  frequencies.Add(c, 1);
          
            return frequencies.Select(kv => new Tuple<char, int>(kv.Key, kv.Value)).ToList();
        }     
    }
}