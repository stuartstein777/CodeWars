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
}
