using System;
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
		if (seconds == 0)
			return "00:00:00";

		var hours = seconds / 3600;
		seconds = seconds - (hours * 3600);
		var minutes = 0;
		if (seconds != 0)
		{
			minutes = seconds / 60;
			seconds = seconds - (minutes * 60);
		}
		return $"{hours:00}:{minutes:00}:{seconds:00}";
    }
}