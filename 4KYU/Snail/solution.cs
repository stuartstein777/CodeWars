using System;
using System.Collections.Generic;

public class SnailSolution
{
   public static int[] Snail(int[][] array)
   {
     if(array.Length == 1 && array[0].Length == 0)
        return new int[]{};
     
      var n = array.Length;
      var x = 0;
      var y = 0;
      var ring = 0;
      var total_rings = n % 2 == 0 ? n / 2 : (n+1)/2;
      var result = new List<int>();
      
      while(ring != total_rings)
      {
        
        // east 
        // (want to go from [y][ring to n-ring])
        for(; x < n - ring; x++)
          result.Add(array[y][x]);
        x--;
        y++;
        // south
        // (want to go from [y to n-ring][x])
        for(; y < n - ring; y++)
          result.Add(array[y][x]);
        y--;
        x--;
        // west
        // (want to go down from [x to ring]
        for(; x >= ring; x--)
          result.Add(array[y][x]);
        x++;
        ring++;
        y--;
        // north
        for(; y >= ring ;y--)
          result.Add(array[y][x]);
        y++;
        x=ring;       
      }
      
      return result.ToArray();
    }

}