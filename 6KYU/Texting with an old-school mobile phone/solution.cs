using System;
using System.Collections.Generic;

class Kata
{   
    private static Dictionary<char, string> KeyPresses = new()
    {
        {'a', "2"},
        {'b', "22"},
        {'c', "222"},
        {'d', "3"},
        {'e', "33"},
        {'f', "333"},
        {'g', "4"},
        {'h', "44"},
        {'i', "444"},
        {'j', "5"},
        {'k', "55"},
        {'l', "555"},
        {'m', "6"},
        {'n', "66"},
        {'o', "666"},
        {'p', "7"},
        {'q', "77"},
        {'r', "777"},
        {'s', "7777"},
        {'t', "8"},
        {'u', "88"},
        {'v', "888"},
        {'w', "9"},
        {'x', "99"},
        {'y', "999"},
        {'z', "9999"},
        {'\'', "*"},
        {'-', "**"},
        {'+', "***"},
        {'=', "****"},
        {' ', "0"},
        {'0', "0-"},
        {'1', "1-"},
        {'2', "2-"},
        {'3', "3-"},
        {'4', "4-"},
        {'5', "5-"},
        {'6', "6-"},
        {'7', "7-"},
        {'8', "8-"},
        {'9', "9-"},
        {'.', "1"},
        {',', "11"},
        {'?', "111"},
        {'!', "1111"},
        {'*', "*-"},
        {'#', "#-"}
    };

    private enum Case
    {
        Lower,
        Upper,
    };
    
    public static string SendMessage(string message)
    {
        var result = string.Empty;
        var currentCase = Case.Lower;
        
        foreach (var c in message.ToCharArray())
        {
            if (char.IsLower(c) && currentCase == Case.Upper ||
                char.IsUpper(c) && currentCase == Case.Lower)
            {
                result += "#";
                
                currentCase = char.IsLower(c) ? Case.Lower : Case.Upper;
            }

            var keys = KeyPresses[char.ToLower(c)];

            if (result.Length > 0 && keys.StartsWith(result[^1].ToString()))
            {
                result += " ";
            }
            
            result += keys;
        }
        return result;
    }
}