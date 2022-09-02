public class Kata
{
  public static string UInt32ToIP(uint ip)
    => $"{(byte)(ip >> 24)}.{(byte)(ip >> 16)}.{(byte)(ip >> 8)}.{(byte)ip}";
}