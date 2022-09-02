using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
    private static Dictionary<string, int> CardsEncoding = new()
    {
        // Clubs        Diamonds      Hearts        Spades
        { "Ac", 0 },  { "Ad", 13 }, { "Ah", 26 }, { "As", 39 },
        { "2c", 1 },  { "2d", 14 }, { "2h", 27 }, { "2s", 40 },
        { "3c", 2 },  { "3d", 15 }, { "3h", 28 }, { "3s", 41 },
        { "4c", 3 },  { "4d", 16 }, { "4h", 29 }, { "4s", 42 },
        { "5c", 4 },  { "5d", 17 }, { "5h", 30 }, { "5s", 43 },
        { "6c", 5 },  { "6d", 18 }, { "6h", 31 }, { "6s", 44 },
        { "7c", 6 },  { "7d", 19 }, { "7h", 32 }, { "7s", 45 },
        { "8c", 7 },  { "8d", 20 }, { "8h", 33 }, { "8s", 46 },
        { "9c", 8 },  { "9d", 21 }, { "9h", 34 }, { "9s", 47 },
        { "Tc", 9 },  { "Td", 22 }, { "Th", 35 }, { "Ts", 48 },
        { "Jc", 10 }, { "Jd", 23 }, { "Jh", 36 }, { "Js", 49 },
        { "Qc", 11 }, { "Qd", 24 }, { "Qh", 37 }, { "Qs", 50 },
        { "Kc", 12 }, { "Kd", 25 }, { "Kh", 38 }, { "Ks", 51 },
    };

    private static List<(string Card, int SuitValue, int CardValue)> CardsDecoding = new()
    {
        ("Ac", 0, 0), ("2c", 0, 1), ("3c", 0, 2), ("4c", 0, 3), ("5c", 0, 4), ("6c", 0, 5),  
        ("7c", 0, 6), ("8c", 0, 7), ("9c", 0, 8), ("Tc", 0, 9), ("Jc", 0, 10), ("Qc", 0, 11),
        ("Kc", 0, 12), 
        
        ("Ad", 1, 0), ("2d", 1, 1), ("3d", 1, 2), ("4d", 1, 3), ("5d", 1, 4), ("6d", 1, 5),
        ("7d", 1, 6), ("8d", 1, 7), ("9d", 1, 8), ("Td", 1, 9), ("Jd", 1, 10),("Qd", 1, 11),
        ("Kd", 1, 12),
        
        ("Ah", 2, 0),  ("2h", 2, 1), ("3h", 2, 2), ("4h", 2, 3), ("5h", 2, 4), ("6h", 2, 5), 
        ("7h", 2, 6),  ("8h", 2, 7), ("9h", 2, 8), ("Th", 2, 9), ("Jh", 2, 10), ("Qh", 2, 11),
        ("Kh", 2, 12),
        
        ("As", 3, 0), ("2s", 3, 1), ("3s", 3, 2), ("4s", 3, 3), ("5s", 3, 4), ("6s", 3, 5),               
        ("7s", 3, 6),  ("8s", 3, 7), ("9s", 3, 8), ("Ts", 3, 9), ("Js", 3, 10), ("Qs", 3, 11),              
        ("Ks", 3, 12)
    };
    
    public static int[] Encode(string[] cards)
        => cards.Select(c => CardsEncoding[c])
                .OrderBy(c => c)
                .ToArray();

    public static string[] Decode(int[] cards)
        => cards.Select(card => CardsDecoding[card])
                .OrderBy(c => c.SuitValue)
                .ThenBy(c => c.CardValue)
                .Select(c => c.Card)
                .ToArray();
}