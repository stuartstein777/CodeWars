public static class Kata
{
    public static bool Interlockable(ulong a, ulong b)
      => (a & b) == 0;
}