using System.Linq;
class Kata
{
    public static string SpecialNumber(int number)
      => (number.ToString().Any(a => "6789".Contains(a))) 
          ? "NOT!!"
          : "Special!!";
 }