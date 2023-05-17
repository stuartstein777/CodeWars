using System.Text.RegularExpressions;
using System.Linq;
using System;

public class Runes
{
    private static (string, string, string, string) ParseExpression(string expression)
    {
        var regex = @"(-?[0-9|?]+)([-|+|*]{1})(-?[0-9|?+]+)=(-?[0-9|?+]+)";
        var match = Regex.Match(expression, regex);
        var number1 = match.Groups[1].Value;
        var number2 = match.Groups[3].Value;
        var operation = match.Groups[2].Value;
        var number3 = match.Groups[4].Value;

        return (number1, number2, operation, number3);
    }
  
    private static bool OnlyZeroes(string s) => s.All(c => c == '0') && s.Length > 1;
    private static bool StartsWithZero(string s) => s.StartsWith("-0") || s.StartsWith("0") && s.Length > 1;
  
    public static int solveExpression(string expression)
    {
        System.Console.WriteLine(expression);
        var (n1s, n2s, op, n3s) = ParseExpression(expression);
        var usedRunes = expression.Where(Char.IsDigit).Select(c => c.ToString()).ToHashSet();
        for (var i = 0; i < 10; i++)
        {
            if (usedRunes.Contains(i.ToString()))
                continue;
          
            var n1si = n1s.Replace("?", i.ToString());
            var n2si = n2s.Replace("?", i.ToString());
            var n3si = n3s.Replace("?", i.ToString());

            if (OnlyZeroes(n1si) || OnlyZeroes(n2si) || OnlyZeroes(n3si) 
                || StartsWithZero(n1si) || StartsWithZero(n2si)|| StartsWithZero(n3si))
                continue;
          
            var n1 = int.Parse(n1si);
            var n2 = int.Parse(n2si);
            var n3 = int.Parse(n3si);

            if (op == "*" && n1 * n2 == n3) return i;
            if (op == "+" && n1 + n2 == n3) return i;
            if (op == "-" && n1 - n2 == n3) return i;
        }
        return -1;
    }
}