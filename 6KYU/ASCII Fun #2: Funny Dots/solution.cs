using System.Linq;
public class Kata
{
    public static string Dot(int w, int h)
    {
        var row = $"\n|{string.Join("|", Enumerable.Repeat(" o ", w))}|\n";
        var splitter = $"+{string.Join("+", Enumerable.Repeat("---", w))}+";
        return $"{splitter}{string.Join($"{splitter}", Enumerable.Repeat(row, h))}{splitter}";
    }
}