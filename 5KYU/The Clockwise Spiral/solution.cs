using System;
using System.Collections.Generic;
public class TheClockwiseSpiral
{
    private static readonly Dictionary<Direction, Direction> NextDirections = new() 
    {
        { Direction.Right, Direction.Down },
        { Direction.Down, Direction.Left },
        { Direction.Left, Direction.Up },
        { Direction.Up, Direction.Right }
    };
  
    public static int[,] CreateSpiral(int n)
    {
        var moves = GetMoves(n);
        var c = 1;
        var result = new int[n,n];
        (int X, int Y) currentXy = (0, 0);
      
        for (var i = 0; i < moves.Count; i++)
        {
            var (direction, amount) = moves[i];
            for (var j = 0; j < amount; j++)
            {
                result[currentXy.Y, currentXy.X] = c;
                if(j < amount-1)
                    currentXy = GetNextXy(currentXy, direction);
                c++;
            }

            if(i != moves.Count-1)
                currentXy = GetNextXy(currentXy, moves[i + 1].Direction);
        }
        
        return result;
    }
  
    private static (int X, int Y) GetNextXy((int X, int Y) currentXy, Direction currentDirection)
        => currentDirection switch
        {
            Direction.Down => (currentXy.X, currentXy.Y + 1),
            Direction.Left => (currentXy.X - 1, currentXy.Y),
            Direction.Right => (currentXy.X + 1, currentXy.Y),
            Direction.Up => (currentXy.X, currentXy.Y - 1)
        };
  
    private static List<(Direction Direction, int Amount)> GetMoves(int n)
    {
        var moves = new List<(Direction, int)> { (Direction.Right, n) };
        var currentDirection = Direction.Right;
        for (var i = 1; i < n; i++)
        {
            currentDirection = NextDirections[currentDirection];
            moves.Add((currentDirection, n - i));
            currentDirection = NextDirections[currentDirection];
            moves.Add((currentDirection, n - i));
        }
        return moves;
    }
}

public enum Direction
{
    Up, Down, Left, Right
}

