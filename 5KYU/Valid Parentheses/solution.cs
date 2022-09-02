using System.Collections.Generic;
using System.Linq;
using System;
public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        Console.WriteLine(input);
        var parens = new Stack<char>();
        foreach (var c in input.ToCharArray())
        {
            if (c == '(')
                parens.Push('(');
            else if (c == ')')
                if(parens.Any())
                    parens.Pop();
                else
                    return false;
        }
        return !parens.Any();
    }
}