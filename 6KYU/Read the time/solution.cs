using System;

public class Solution
{
    private static string[] _hours = 
    {
        "midnight", "one", "two", "three", "four", "five", "six", "seven",
        "eight", "nine", "ten", "eleven", "twelve", "one", "two",
        "three", "four", "five", "six", "seven", "eight",
        "nine", "ten", "eleven", "midnight",
    };

    private static string[] _minutes =
    {
        "", "one", "two", "three", "four", "five", "six", "seven",
        "eight", "nine", "ten", "eleven", "twelve", "thirteen",
        "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
        "nineteen", "twenty", "twenty one", "twenty two", "twenty three",
        "twenty four", "twenty five", "twenty six", "twenty seven",
        "twenty eight", "twenty nine", "thirty", "thirty one", "thirty two",
        "thirty three", "thirty four", "thirty five", "thirty six",
        "thirty seven", "thirty eight", "thirty nine", "forty", "forty one",
        "forty two", "forty three", "forty four", "forty five", "forty six",
        "forty seven", "forty eight", "forty nine", "fifty", "fifty one",
        "fifty two", "fifty three", "fifty four", "fifty five", "fifty six",
        "fifty seven", "fifty eight", "fifty nine"
    };
    
    public static string solve(string time){
        var hours = int.Parse(time.Split(":")[0]) % 24;
        var minutes = int.Parse(time.Split(":")[1]);

        if (hours == 0 && minutes == 0) return "midnight";
        
        return minutes switch
        {
            0 => $"{_hours[hours]} o'clock",
            15 => $"quarter past {_hours[hours]}",
            30 => $"half past {_hours[hours]}",
            45 => $"quarter to {_hours[(hours+1) % 24]}",
            < 30 => $"{_minutes[minutes]} minute{(minutes == 1 ? "" : "s")} past {_hours[hours]}",
            > 30 => $"{_minutes[60 - minutes]} minute{(minutes == 59 ? "" : "s")} to {_hours[(hours+1) % 24]}"
        };
    }
}