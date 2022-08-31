public class Kata
{
  public bool DistinctDigits(short year)
  {
    var chars = year.ToString().ToCharArray();
    return chars[0] != chars[1] && chars[0] != chars[2] && chars[0] != chars[3] &&
           chars[1] != chars[2] && chars[1] != chars[3] && chars[2] != chars[3];
  }
  
  public short nextHappyYear(short year)
  {
    do
    {
      year++;
    }
    while(!DistinctDigits(year));
    return year;
  }
}