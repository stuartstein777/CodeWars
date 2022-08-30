namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int CircleOfNumbers(int n, int firstNumber)
          => (firstNumber + n / 2) % n;
    }
}