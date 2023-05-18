using System;
using System.Collections.Generic;

public class Kata
{
  public static IEnumerable<(int X, int Y)> GetNeighbours(int x, int y, int w, int h)
  {
	    var neighbours = new List<(int, int)>();

 	    if(x > 0)
   		    neighbours.Add((x-1, y));

	    if(x < w-1)
  		    neighbours.Add((x+1, y));

	    if(y < h-1) 
  		    neighbours.Add((x, y+1));

	    if(y > 0)
  		    neighbours.Add((x, y-1));
		
	    return neighbours;
  }
  
  public static int[,] FloodFill(int[,] grid, int y, int x, int newValue){
     var gw = grid.GetLength(0);
     var gh = grid.GetLength(1);
     var ov = grid[y, x];
	 
     var neighbours = new Stack<(int X, int Y)>();
     neighbours.Push((y, x));
    
     while(neighbours.Count > 0)
     {
          var (ny, nx) = neighbours.Pop();
		  
          if(grid[ny, nx] == ov)
          {
              grid[ny, nx] = newValue;
       
              var newNeighbours = GetNeighbours(ny, nx, gh, gw);
            
              foreach(var neighbour in newNeighbours)
                  neighbours.Push(neighbour);
          }
		  
     }
    
     return grid;
  }
}