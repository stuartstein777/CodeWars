public class Kata
{
  private static uint Next(uint n)
     => n % 2 == 0 ? n / 2 : 3 * n + 1;
  
  public static uint Hotpo(uint n)
  {
       uint c = 0;
       while(n != 1)
       {
          c++;
          n = Next(n);
       }
       return c;
  }
}