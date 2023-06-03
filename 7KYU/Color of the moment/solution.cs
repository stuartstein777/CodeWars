using System;
using System.Text;
using System.Text.RegularExpressions;

public class Kata
{
    public string HexToTime(string hex)
    {
        var hrsHex = hex.Substring(1, 2);
        var minsHex = hex.Substring(3, 2);
        var secsHex = hex.Substring(5, 2);
               
        var hrs = int.Parse(hrsHex, System.Globalization.NumberStyles.HexNumber);
        var mins = int.Parse(minsHex, System.Globalization.NumberStyles.HexNumber);
        var secs = int.Parse(secsHex, System.Globalization.NumberStyles.HexNumber);

        if (mins >= 60 || secs >= 60 || hrs >= 24)
            throw new Exception("Invalid time!");
        
        return $"{hrs:D2}:{mins:D2}:{secs:D2}";
    }
}