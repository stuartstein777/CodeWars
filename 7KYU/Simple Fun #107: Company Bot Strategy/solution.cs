namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public double CompanyBotStrategy(int[][] trainingData){
          var totalTime = 0.0;
          var correct = 0.0;
          
          for(var i = 0; i < trainingData.Length; i++)
          {
             if(trainingData[i][1] == 1)
             {
               correct ++;
               totalTime += trainingData[i][0];
             }
          }
          
          return correct == 0 ? 0 : totalTime / correct;
        }
    }
}