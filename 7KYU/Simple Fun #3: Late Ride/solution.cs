namespace myjinxin
{
    using System;
    
    public class Kata
    {
       private static int SumDigits(int n)
       {
           var sum = 0;
           while(n != 0)
           {
               sum += (n % 10);
               n /= 10;
           }
           return sum;
        }
      
        public int LateRide(int n)
        {
           var hours = n / 60;
           n = n - (hours * 60);
           return SumDigits(n) + SumDigits(hours);       
        }
    }
}