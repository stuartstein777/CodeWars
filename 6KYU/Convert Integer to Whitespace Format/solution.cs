using System;
public class Kata
{
  public static string WhitespaceNumber(int n)
  {
    Console.WriteLine(n);
    if(n == 0)
      return " \n";
    var res = Convert.ToString(Math.Abs(n), 2)
				  	 .Replace("0", " ")
				  	 .Replace("1", "\t");
					 
	  return (n >= 0)
		  ? " " + res + "\n"
		  : "\t" + res + "\n";
  }
}