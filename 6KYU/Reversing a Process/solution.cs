using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Decoding
{
    public static string Decode(string r)
    {
        const string check = "abcdefghijklmnopqrstuvwxyz";
        var (n, msg) = SplitNumAndMessage(r);
        try
        {
            var decoded = msg.ToCharArray().Select(c => DecodeChar(c, n));
            return decoded.All(c => check.Contains(c)) ? string.Concat(decoded) : "Impossible to decode";
        }
        catch (Exception e)
        {
            return "Impossible to decode";
        }
    }
    
    private static char DecodeChar(char c, int n)
        => (char)(((((int)c - 97) * ModInverse(n, 26)) % 26) + 97);

    private static (int I, string S) SplitNumAndMessage(string s)
    {
        var matches = new Regex(@"(\d+)(.+)").Match(s);
        return (int.Parse(matches.Groups[1].Value), matches.Groups[2].Value);
    }
  
    private static int ModInverse(int a, int m)
    {
        if (m == 1) return 0;
        var m0 = m;
        var (x, y) = (1, 0);
 
        while (a > 1) {
            var q = a / m;
            (a, m) = (m, a % m);
            (x, y) = (y, x - q * y);
        }
        return x < 0 ? x + m0 : x;
    }
  
}