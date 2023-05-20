using System;
using System.Linq;
public static class Kata
{
    public static string Remove(string s)
    {
        var withoutExclams = string.Join("", s.ToCharArray().Where(x => x != '!').ToArray());
        var exclamsRemoved = s.Length - withoutExclams.Length;
        var exclams = string.Join("", Enumerable.Repeat("!", exclamsRemoved).ToArray());
        return withoutExclams + exclams;      
    }
}