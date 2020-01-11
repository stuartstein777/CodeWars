public static class Kata
{
	public static string bonus_time(int salary, bool bonus) => bonus ? $"${salary*10}" : $"${salary}";
}