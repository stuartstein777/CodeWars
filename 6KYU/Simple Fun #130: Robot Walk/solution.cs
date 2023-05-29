namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    
    public class Kata
    {
        private (List<(int, int)>, (int, int)) Visited((int X, int Y) current, Direction direction, int distance)
        {
            List<(int, int)> visited = new();

            for (var i = 0; i < distance; i++)
            {
                if (direction == Direction.East) current.X++;
                if (direction == Direction.West) current.X--;
                if (direction == Direction.North) current.Y++;
                if (direction == Direction.South) current.Y--;
                visited.Add(current);
            }
            return (visited, current);
        }

        public bool RobotWalk(int[] steps)
        {
            var (x, y) = (0, 0);
            var visited = new HashSet<(int, int)>();
            visited.Add((x, y));
            var currentDirection = Direction.North;
            foreach (var step in steps)
            {
                var (newVisited, currentXY) = Visited((x, y), currentDirection, step);
                if(currentDirection == Direction.North) currentDirection = Direction.East;
                else if(currentDirection == Direction.East) currentDirection = Direction.South;
                else if(currentDirection == Direction.South) currentDirection = Direction.West;
                else if(currentDirection == Direction.West) currentDirection = Direction.North;

                (x, y) = currentXY;
              
                foreach (var v in newVisited)
                {
                    if (visited.Contains(v))
                        return true;
                    visited.Add(v);
                }
            }

            return false;
        }
    }
  
  public enum Direction
  {
      North,
      East,
      South,
      West
  }
}