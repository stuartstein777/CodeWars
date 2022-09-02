using System;
class Kata
{
    public static string JumpingNumber(int number)
    {
      Console.WriteLine(number);
       var split = number.ToString().ToCharArray();
       for(var i = 0; i < split.Length -1; i++)
         if(Math.Abs(split[i] - split[i+1]) > 1)
            return "Not!!";
        return "Jumping!!";
    }
}