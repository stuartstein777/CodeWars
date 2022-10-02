using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution {
  public static class Kata
{
    public static Dictionary<char, string> NextChar
        = new Dictionary<char, string>
        {
            {'a', "b"},{'b', "c"},{'c', "d"},{'d', "e"},{'e', "f"},{'f', "g"},{'g', "h"},{'h', "i"},
            {'i', "j"},{'j', "k"},{'k', "l"},{'l', "m"},{'m', "n"},{'n', "o"},{'o', "p"},{'p', "q"},
            {'q', "r"},{'r', "s"},{'s', "t"},{'t', "u"},{'u', "v"},{'v', "w"},{'w', "x"},{'x', "y"},
            {'y', "z"},{'z', "a"}
        };
    public static string last_survivors(string str)
    {
        while (true)
        {
            Console.WriteLine(str);
            var groups = str.GroupBy(c => c);
            var substituteMade = false;
            var res = "";
            foreach (var group in groups)
            {
                Console.WriteLine($"\t{group.Key} : {group.Count()}");
                if (group.Count() >= 2)
                {
                    var pairs = (int)Math.Floor(group.Count() / 2.0);
                    var originalChars = group.Count() % 2;
                    substituteMade = true;
                    res += string.Join("", Enumerable.Repeat(NextChar[group.Key], pairs));
                    if (originalChars > 0)
                        res += group.Key.ToString();
                }
                else
                    res += group.Key.ToString();
            }

            if (!substituteMade)
                return res;

            str = res;
            //Console.ReadKey();
        }
    }
  }
}