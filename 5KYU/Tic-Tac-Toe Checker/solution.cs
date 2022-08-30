using System;
using System.Collections.Generic;
using System.Linq;
public class TicTacToe
{
    private static bool IsFinished(int[,] board) 
        => board.Cast<int>().All(xy => xy != 0);

    private static readonly List<List<(int X, int Y)>> winningStates
        = new List<List<(int X, int Y)>>
            {  new List<(int X, int Y)>{(0, 0), (0, 1), (0, 2) },
               new List<(int X, int Y)>{(1, 0), (1, 1), (1, 2) },
               new List<(int X, int Y)>{(2, 0), (2, 1), (2, 2) },
               new List<(int X, int Y)>{(0, 0), (1, 0), (2, 0) },
               new List<(int X, int Y)>{(0, 1), (1, 1), (2, 1) },
               new List<(int X, int Y)>{(0, 2), (1, 2), (2, 2) },
               new List<(int X, int Y)>{(0, 0), (1, 1), (2, 2) },
               new List<(int X, int Y)>{(0, 2), (1, 1), (2, 0) }
            };
    
    public int IsSolved(int[,] board)
    {
        // check if there is a winner.
        foreach (var i in Enumerable.Range(1, 2))
        {
            foreach (var ws in winningStates)
                if (ws.Select(xy => board[xy.X, xy.Y]).All(n => n == i))
                    return i;
        }
        // no winners, so check if the board is finished, if it its a draw.
        if (board.Cast<int>().All(xy => xy != 0))
             return 0;
        
        // else the game is not finished.
        return -1;
    }
}