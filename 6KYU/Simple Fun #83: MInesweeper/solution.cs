namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Kata
    {
       private int NeighbouringMines(bool[][] matrix, int y, int x)
          => new List<(int X, int Y)>
                {
                   (x - 1, y - 1),
                   (x - 1, y),
                   (x - 1, y + 1),
                   (x, y - 1),
                   (x, y + 1),
                   (x + 1, y + 1),
                   (x + 1, y - 1),
                   (x + 1, y)
                }
                .Where(xy => xy is { X: >= 0, Y: >= 0 } && xy.Y < matrix.Length && xy.X < matrix[0].Length)
                .Select(xy => matrix[xy.Y][xy.X])
                .Count(c => c);
      
        public int[][] Minesweeper(bool[][] matrix){
            var res = new int[matrix.Length][];

            for (var y = 0; y < matrix.Length; y++)
            {
                var row = new int[matrix[0].Length];
                res[y] = row;
                for (var x = 0; x < matrix[0].Length; x++)
                {
                    res[y][x] = NeighbouringMines(matrix, y, x);
                }
            }
            return res;
        }
    }
}