namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public long PressButton(long n){
          var presses = 0L;
          var correct = 0L;
          
          while(n != 0) {
            presses += (n-correct) + (n * correct);
            correct++;
            n--;
          }
          return presses-n;          
        }
    }
}