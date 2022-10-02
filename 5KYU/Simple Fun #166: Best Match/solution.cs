namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int BestMatch(int[] goals1, int[] goals2)
    {
        int smallestGoalDiff = goals1[0] - goals2[0];
        int idx = 0;
        int g = goals2[0];
        for(var i = 1; i < goals1.Length; i++)
        {
            var goalDiff = goals1[i] - goals2[i];
            if(goalDiff < smallestGoalDiff)
            {
                smallestGoalDiff = goalDiff;
                idx = i;
                g = goals2[i];
            } else if (goalDiff == smallestGoalDiff && goals2[i] > g)
            {
                g = goals2[i];
                idx = i;
            }
        }
        return idx;
    }
  }
}