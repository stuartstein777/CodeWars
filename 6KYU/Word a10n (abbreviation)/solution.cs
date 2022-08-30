using System.Linq;
using System.Text.RegularExpressions;
public class Abbreviator
{
    private static string Abbrev(string w)
        => new Regex(@"\w+").IsMatch(w) && w.Length >= 4
            ? $"{w.First()}{w.Length - 2}{w.Last()}"
            : w;

    public static string Abbreviate(string input)
        => string.Join("", Regex.Split(input, @"\b").Select(Abbrev));
}