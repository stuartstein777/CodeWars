public class Kata
{
  public static string BuyOrPass(double stockPrice, double allTimeHigh)
  {
    return (stockPrice / allTimeHigh * 100) <= 80
      ? "Buy"
      : "Pass";
  }
}