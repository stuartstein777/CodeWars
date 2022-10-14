using System.Collections.Generic;
using System.Linq;
using System;
public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        Console.WriteLine(s);
        var charCounts = new Dictionary<char, (int Pos, int Count, char c)>();
        for(var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if(charCounts.ContainsKey(char.ToLower(c)))
            {
                var cur = charCounts[char.ToLower(c)];
                cur.Count++;
                charCounts[char.ToLower(c)] = cur;
            }
            else
            {
                charCounts.Add(char.ToLower(c), (i, 1, c));
            }
        }

        var (key, value) = charCounts.Where(cc => cc.Value.Count == 1)
            .OrderBy(cc => cc.Value.Pos)
            .FirstOrDefault();

        return value.Count == 0 ? string.Empty : value.Item3.ToString();
    }
}