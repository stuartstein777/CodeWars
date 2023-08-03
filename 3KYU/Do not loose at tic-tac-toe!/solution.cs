using System.Collections.Generic;
using System.Linq;

public class TTTSolver
{
    private static (int X, int Y) FindForkForcingMove(int[][] board, int player, int opp)
    {
        if ((board[0][0] == opp && board[2][2] == opp && board[1][1] == player) ||
            (board[0][2] == opp && board[2][0] == opp && board[1][1] == player))
        {
            if (board[1][0] == 0) return (1, 0);
            if (board[0][1] == 0) return (0, 1);
            if (board[1][2] == 0) return (1, 2);
            if (board[2][1] == 0) return (2, 1);
        }
        return (-1, -1);
    }
    
    private static (int X, int Y) FindEmptySide(int[][] board)
    {
        if (board[0][1] == 0)
            return (0, 1);
        if (board[1][0] == 0)
            return (1, 0);
        if (board[1][2] == 0)
            return (1, 2);
        if (board[2][1] == 0)
            return (2, 1);
        return (-1, -1);
    }
    
    private static (int X, int Y) FindEmptyCorner(int[][] board)
    {
        if (board[0][0] == 0)
            return (0, 0);
        if (board[2][2] == 0)
            return (2, 2);
        if (board[0][2] == 0)
            return (0, 2);
        if (board[2][0] == 0)
            return (2,0);
        return (-1, -1);
    }
    
    private static (int X, int Y) FindOppositeCorner(int[][] board, int player)
    {
        if (board[0][0] != 0 && board[0][0] != player && board[2][2] == 0)
            return (2, 2);
        if (board[0][2] != 0 && board[0][2] != player && board[2][0] == 0)
            return (2, 0);
        if (board[2][0] != 0 && board[2][0] != player && board[0][2] == 0)
            return (0, 2);
        if (board[2][2] != 0 && board[2][2] != player && board[0][0] == 0)
            return (0, 0);
        return (-1, -1);
    }
    
    /*
     * There are only 9 squares. We can try setting each one to the player and 
     * see if it results more than 1 possible win states. If it does, then it's a fork.
     * e.g.
     *
     * ┏━━━━━┳━━━━━┳━━━━━┓
     * ┃  1  ┃  0  ┃  2  ┃
     * ┣━━━━━╋━━━━━╋━━━━━┫
     * ┃  X  ┃  1  ┃  A  ┃
     * ┣━━━━━╋━━━━━╋━━━━━┫
     * ┃  B  ┃     ┃  2  ┃
     * ┗━━━━━┻━━━━━┻━━━━━┛
     *
     * Can play in X, as possible wins will then be A and B.
     */
    private static List<(int X, int Y)> FindFork(int[][] board, int player)
    {
        List<(int X, int Y)> forks = new();
        
        for (var x = 0; x < 3; x++)
        {
            for (var y = 0; y < 3; y++)
            {
                if (board[x][y] != 0)
                    continue;
                
                // var newBoard = new int[3][];
                // for (var i = 0; i < 3; i++)
                // {
                //     newBoard[i] = new int[3];
                //     for (var j = 0; j < 3; j++)
                //     {
                //         newBoard[i][j] = board[i][j];
                //     }
                // }
                //
                
                board[x][y] = player;
                var wins = FindWins(board, player);
                if (wins.Count > 1)
                    forks.Add((x, y));

                board[x][y] = 0;
            }
        }
        
        return forks;
    }
    
    /*
     * Possible wins:
     * [(0,0), (0,1), (0,2)]
     * [(1,0), (1,1), (1,2)]
     * [(2,0), (2,1), (2,2)]
     * [(0,0), (1,0), (2,0)]
     * [(0,1), (1,1), (2,1)]
     * [(0,2), (1,2), (2,2)]
     * [(0,0), (1,1), (2,2)]
     * [(0,2), (1,1), (2,0)]
     * 
     * ┏━━━━━┳━━━━━┳━━━━━┓
     * ┃ 0,0 ┃ 0,1 ┃ 0,2 ┃
     * ┣━━━━━╋━━━━━╋━━━━━┫    
     * ┃ 1,0 ┃ 1,1 ┃ 1,2 ┃
     * ┣━━━━━╋━━━━━╋━━━━━┫
     * ┃ 2,0 ┃ 2,1 ┃ 2,2 ┃
     * ┗━━━━━┻━━━━━┻━━━━━┛
     *
     * Call with playerId to check for wins.
     * Call with other playerId to check for wins to block.
     *
     * Want to return all possible wins, so we can check if there are more than 1 for
     * possible forks.
     */
    private static List<(int X, int Y)> FindWins(int[][] board, int player)
    {
        List<(int X, int Y)> wins = new();
        
        // [(0,0), (0,1), (0,2)]
        if (board[0][0] == player && board[0][1] == player && board[0][2] == 0)
            wins.Add((0, 2));
        if (board[0][0] == player && board[0][1] == 0 && board[0][2] == player) 
            wins.Add((0, 1));
        if (board[0][0] == 0 && board[0][1] == player && board[0][2] == player)
            wins.Add((0, 0));
        
        // [(1,0), (1,1), (1,2)]
        if (board[1][0] == player && board[1][1] == player && board[1][2] == 0)
            wins.Add((1, 2));
        if (board[1][0] == player && board[1][1] == 0 && board[1][2] == player)
            wins.Add((1, 1));
        if (board[1][0] == 0 && board[1][1] == player && board[1][2] == player)
            wins.Add((1, 0));

        // [(2,0), (2,1), (2,2)]
        if (board[2][0] == player && board[2][1] == player && board[2][2] == 0)
            wins.Add((2, 2));
        if (board[2][0] == player && board[2][1] == 0 && board[2][2] == player)
            wins.Add((2, 1));
        if (board[2][0] == 0 && board[2][1] == player && board[2][2] == player)
            wins.Add((2, 0));
        
        // [(0,0), (1,0), (2,0)]
        if (board[0][0] == player && board[1][0] == player && board[2][0] == 0)
            wins.Add((2, 0));
        if (board[0][0] == player && board[1][0] == 0 && board[2][0] == player)
            wins.Add((1, 0));
        if (board[0][0] == 0 && board[1][0] == player && board[2][0] == player)
            wins.Add((0, 0));
        
        // [(0,1), (1,1), (2,1)]
        if (board[0][1] == player && board[1][1] == player && board[2][1] == 0)
            wins.Add((2, 1));
        if (board[0][1] == player && board[1][1] == 0 && board[2][1] == player)
            wins.Add((1, 1));
        if (board[0][1] == 0 && board[1][1] == player && board[2][1] == player)
            wins.Add((0, 1));
        
        // [(0,2), (1,2), (2,2)]
        if (board[0][2] == player && board[1][2] == player && board[2][2] == 0)
            wins.Add((2, 2));
        if (board[0][2] == player && board[1][2] == 0 && board[2][2] == player)
            wins.Add((1, 2));
        if (board[0][2] == 0 && board[1][2] == player && board[2][2] == player)
            wins.Add((0, 2));
        
        // [(0,0), (1,1), (2,2)]
        if (board[0][0] == player && board[1][1] == player && board[2][2] == 0)
            wins.Add((2, 2));
        if (board[0][0] == player && board[1][1] == 0 && board[2][2] == player)
            wins.Add((1, 1));
        if (board[0][0] == 0 && board[1][1] == player && board[2][2] == player)
            wins.Add((0, 0));
        
        // [(0,2), (1,1), (2,0)]
        if (board[0][2] == player && board[1][1] == player && board[2][0] == 0)
            wins.Add((2, 0));
        if (board[0][2] == player && board[1][1] == 0 && board[2][0] == player)
            wins.Add((1, 1));
        if (board[0][2] == 0 && board[1][1] == player && board[2][0] == player)
            wins.Add((0, 2));
        
        return wins;
    }
    
    /*
     * Look for wins.
     * Look to block wins.
     * Look for forks.
     * Look to block forks.
     * Look for center.
     * Look for opposite corner.
     * Look for empty corner.
     * Look for empty side.
     */
    public static int[] TurnMethod(int[][] board, int player)
    {
        var opp = player == 1 ? 2 : 1;
        
        // Look for win
        var wins = FindWins(board, player);
        
        if(wins.Any())
            return new[] { wins[0].X, wins[0].Y };

        // No win, so look for a win that we need to block.
        var winsToBlock = FindWins(board, opp);
        
        if(winsToBlock.Any())
            return new[] { winsToBlock[0].X, winsToBlock[0].Y };
        
        // No win to block, so look for a fork.
        var forks = FindFork(board, player);

        if (forks.Any())
            return new[] { forks[0].X, forks[0].Y };
        
        // No fork, so look for a fork to block.
        var forksToBlock = FindFork(board, opp);
        
        // if a single fork, block it.
        if (forksToBlock.Count() == 1)
            return new[] { forksToBlock[0].X, forksToBlock[0].Y };
        
        // if there are multiple forks, we can only block by playing a
        // move that forces the opponent to block our win.
        var blockingMove = FindForkForcingMove(board, player, opp);
        if (blockingMove.X != -1)
            return new[] { blockingMove.X, blockingMove.Y };
        
        // No fork to block, so look for center.
        if (board[1][1] == 0)
            return new[] { 1, 1 };
        
        // No center, so look for opposite corner.
        var oppositeCorner = FindOppositeCorner(board, player);
        
        if (oppositeCorner.X != -1)
            return new[] { oppositeCorner.X, oppositeCorner.Y };
        
        // No opposite corner, so look for empty corner.
        var emptyCorner = FindEmptyCorner(board);
        if(emptyCorner.X != -1)
            return new[] { emptyCorner.X, emptyCorner.Y };
        
        // No empty corner, so look for empty side.
        var emptySide = FindEmptySide(board);
        if(emptySide.X != -1)
            return new[] { emptySide.X, emptySide.Y };
        
        // Return first empty spot.
        for(var i = 0; i < 3; i++)
            for(var j = 0; j < 3; j++)
                if(board[i][j] == 0)
                    return new[] { i, j };
        
        return null;
    }
}
