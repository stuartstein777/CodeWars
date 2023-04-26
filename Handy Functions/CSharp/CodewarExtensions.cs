public static class CodewarExtensions
{

    public static string OrdinalSuffix(this int n)
    {
        var j = n % 10;
        var k = n % 100;
        return j switch
        {
            1 when k != 11 => "st",
            2 when k != 12 => "nd",
            3 when k != 13 => "rd",
            _ => "th"
        };
    }

    public static IEnumerable<int> AllIndexesOf(this string str, string searchstring)
    {
        var minIndex = str.IndexOf(searchstring);
        while (minIndex != -1)
        {
            yield return minIndex;
            minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length);
        }
    }

    public static string Reverse(this string s) => string.Join("", s.ToCharArray().Reverse());
}
