using System;
using System.Collections.Generic;
using System.Linq;

public class Dinglemouse
{
    private const int _undefinedHeight = -2;
    private const int _isRiver = -10;
    private static int[][] InitializeTerrainHeightMap(int height, int width, char[][] terrain)
    {
        var heightMap = new int[height][];
        
        for (var i = 0; i < height; i++)
        {
            heightMap[i] = new int[width];
            for (var j = 0; j < width; j++)
                if (terrain[i][j] == '-')
                    heightMap[i][j] = _isRiver;
                else if (terrain[i][j] != '^')
                    heightMap[i][j] = 0;
                else
                {
                    // its a mountain.
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        heightMap[i][j] = 1;
                    else
                        heightMap[i][j] = _undefinedHeight;
                }
        }

        return heightMap;
    }

    private static List<int> GetNeighbours(int[][] heights, int i, int j)
    {
        List<int> neighbourHeights = new();
        
        if(i > 0)
            neighbourHeights.Add(heights[i-1][j]);
        if (j < heights[0].Length - 1)
            neighbourHeights.Add(heights[i][j+1]);
        if (i < heights.Length - 1)
            neighbourHeights.Add(heights[i+1][j]);
        if (j > 0)
            neighbourHeights.Add(heights[i][j-1]);
        return neighbourHeights;
    }
    
    public static int[][] BuildTerrainHeightMap(char[][] terrain)
    {
        var heightMap = InitializeTerrainHeightMap(terrain.Length, terrain[0].Length, terrain);
        bool heightChangeMade;
        var runAfterInit = true;
        var height = 1;
        do
        {
            if (runAfterInit)
            {
                runAfterInit = false;
                heightChangeMade = true;
            }
            else
                heightChangeMade = false;
            
            for (var i = 0; i < terrain.Length-1; i++)
            {
                for (var j = 0; j < terrain[0].Length-1; j++)
                {
                    if (heightMap[i][j] != _undefinedHeight)
                        continue;
                    
                    var neighbourHeights = GetNeighbours(heightMap, i, j);
                    if(neighbourHeights.Any(c => c == height-1 || c == _isRiver))
                    {
                        heightMap[i][j] = height;
                        heightChangeMade = true;
                    }
                }
            }
            height++;
        } while (heightChangeMade);

        return heightMap;
    }
    
    private static List<(int X, int Y)> FindRivers(int[][] heightMap)
    {
        List<(int X, int Y)> rivers = new();
        for (var i = 0; i < heightMap.Length; i++)
        {
            for (var j = 0; j < heightMap[0].Length; j++)
            {
                if (heightMap[i][j] == _isRiver)
                    rivers.Add((i, j));
            }
        }

        return rivers;
    }

    private static string GetRiverIcon(int heightMapIndicator)
    {
        return heightMapIndicator switch
        {
            _isRiver => "≈",
            _undefinedHeight => " ",
            _ => $"{heightMapIndicator}"
        };
    }

    private static int GetLandCount(int[][] heightMap)
        => heightMap.SelectMany(t => t)
                    .Count(j => j >= 0);

    private static List<(int X, int Y)> NeighboursToFlood((int X, int Y) current, int[][] heightMap, int riverHeight)
    {
        // get N,E,S,W neighbours of current if they are not already flooded (-10)
        // and have value less than riverHeight
        var neighbours = new List<(int X, int Y)>();
        if (current.X > 0 && heightMap[current.X - 1][current.Y] < riverHeight && heightMap[current.X - 1][current.Y] != _isRiver)
            neighbours.Add((current.X - 1, current.Y));
        if (current.Y < heightMap[0].Length - 1 && heightMap[current.X][current.Y + 1] < riverHeight && heightMap[current.X][current.Y + 1] != _isRiver)
            neighbours.Add((current.X, current.Y+1));
        if (current.X < heightMap.Length - 1 && heightMap[current.X + 1][current.Y] < riverHeight && heightMap[current.X + 1][current.Y] != _isRiver)
            neighbours.Add((current.X+1, current.Y));
        if (current.Y > 0 && heightMap[current.X][current.Y - 1] < riverHeight && heightMap[current.X][current.Y - 1] != _isRiver)
            neighbours.Add((current.X, current.Y-1));
        return neighbours;
    }
    
    private static int[][] DoRound(int[][] heightMap, int riverHeight)
    {       
        var rivers = FindRivers(heightMap);
        var processed = new HashSet<(int X, int Y)>();
        var toProcess = new Stack<(int X, int Y)>(rivers);
        
        HashSet<(int X, int Y)> Processed = new();

        while (toProcess.Any())
        {
            var current = toProcess.Pop();
            
            if (Processed.Contains(current))
                continue;

            var neighbours = NeighboursToFlood(current, heightMap, riverHeight);
            foreach (var neighbour in neighbours)
            {
                toProcess.Push(neighbour);
            }

            processed.Add(current);
            heightMap[current.X][current.Y] = _isRiver;
        }
        
        return heightMap;
    }
    
    public static int[] DryGround(char[][] terrain)
    {
        if(!terrain.Any())
            return new int[]{0,0,0,0};

        var heightMap = BuildTerrainHeightMap(terrain);
        List<int> heights = new();
       
        var land = GetLandCount(heightMap);
        heights.Add(land);
        
        heightMap = DoRound(heightMap, 1);
        heights.Add(GetLandCount(heightMap));
        
        heightMap = DoRound(heightMap, 2);
        heights.Add(GetLandCount(heightMap));
        
        heightMap = DoRound(heightMap, 3);
        heights.Add(GetLandCount(heightMap));
        
        return heights.ToArray();
    }
    
}