using System.Collections.Generic;
public class Kata
{
    private static Dictionary<string, string> Substitutions = new()
    {
        {"A", "Ä"}, {"E", "Ë"}, {"I", "Ï"}, {"O", "Ö"}, {"U", "Ü"}, {"Y", "Ÿ"},
        {"a", "ä"}, {"e", "ë"}, {"i", "ï"}, {"o", "ö"}, {"u", "ü"}, {"y", "ÿ"}
    };
    public static string HeavyMetalUmlauts(string boringText)
    {
        foreach (var (k, v) in Substitutions)
            boringText = boringText.Replace(k, v);
        return boringText;
    }
}