using System.Linq;
class Kata
{
    public static double Factorial(int n)
    {
       System.Console.WriteLine(n);
       double res = 1;
      
       for(int i = 1; i <= n; i++)
       {
          res*=i;
       }
      
       System.Console.WriteLine(res);
       return res;
    }
  
    public static string StrongNumber(int number)
    {
        var res = number.ToString()
                        .ToCharArray()
                        .Select(x => Factorial(int.Parse(x.ToString())))  
                        .Sum();
      
      if(res == number)
        return "STRONG!!!!";
      return "Not Strong !!";      
    }
}