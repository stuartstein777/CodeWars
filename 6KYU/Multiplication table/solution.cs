using System;

namespace Solution
{
  class Solution
  {
    public static int[,] MultiplicationTable(int size)
    {
      int [,] res = new int[size, size];
      for(var i = 0; i < size; i++)
         for(var j = 0; j < size; j++)
            res[i,j] = (i+1) * (j+1);
      
      return res;
    }
  }
}