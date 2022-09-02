using System.Linq;
using System.Collections.Generic;
using System;
class Kata
{
    public static string DisariumNumber(int number)
{
  var sum = 0;
  var i = 1;
  foreach(var d in GetDigits(number))
  {
    sum += (int)Math.Pow(d, i);
    i++;
  }
  
  return (sum == number)
    ? "Disarium !!"
      : "Not !!";
}

public static IEnumerable<int> GetDigits(int number)
{
  var digits = new List<int>();
  
  while(number != 0)
  {
    digits.Add(number % 10);
    number = (int)Math.Floor((number / 10.0));
  }
  return digits.AsEnumerable().Reverse();
}
}