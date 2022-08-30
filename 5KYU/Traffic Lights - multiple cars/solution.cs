using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
public class Dinglemouse
{
    public static string[] TrafficLights(string road, int n)
    {
        Console.WriteLine(road);
        var trafficLights = GetTrafficLights(road);
        var cars = GetCarLocations(road);
        var roads = new List<string> {road};
        for (var i = 0; i < n; i++)
        {
            trafficLights = UpdateTrafficLights(trafficLights);
            cars = UpdateCarLocations(road.Length, cars, trafficLights);
            roads.Add(BuildRoad(cars, trafficLights, road.Length));
        }
        return roads.ToArray();
    }

    private static string BuildRoad(
        IReadOnlySet<int> cars,
        IReadOnlyDictionary<int, (char LightColor, int TimeInState)> trafficLights,
        int roadLength)
    {
        var road = "";
        for (var i = 0; i < roadLength; i++)
        {
            if (cars.Contains(i))
                road += "C";
            else if (trafficLights.ContainsKey(i))
                road += trafficLights[i].LightColor;
            else
                road += ".";
        }
        return road;
    }

    private static HashSet<int> UpdateCarLocations(
        int roadLength,
        ICollection<int> cars,
        IReadOnlyDictionary<int, (char LightColor, int TimeInState)> trafficLights)
    {
        var updatedCars = new HashSet<int>();
        foreach (var car in cars.OrderByDescending(c => c))
        {
            if (trafficLights.ContainsKey(car + 1) && // there is a traffic light in next cell
                trafficLights[car + 1].LightColor == 'G' && // and that traffic light is green
                !updatedCars.Contains(car + 2)) // and won't be blocked.
            {
                if(car + 1 < roadLength)
                    updatedCars.Add(car + 1);
                cars.Remove(car);
            }
            else if (!trafficLights.ContainsKey(car + 1) && // no traffic light ahead.
                     !cars.Contains(car + 1) && // no car ahead currently
                     !updatedCars.Contains(car + 1)) // no car ahead in waiting to move forward.
            {
                if(car + 1 < roadLength)
                    updatedCars.Add(car + 1);
                cars.Remove(car);
            }

            else
                updatedCars.Add(car);
        }
        return updatedCars;
    }

    private static Dictionary<int, (char LightColor, int TimeInState)> UpdateTrafficLights(
        Dictionary<int, (char LightColor, int TimeInState)> trafficLights)
    {
        Dictionary<int, (char LightColor, int TimeInState)> updated = new();
        foreach (var (key, (lightColor, timeInState)) in trafficLights)
        {
            if(lightColor == 'G' && timeInState == 4)
                updated.Add(key, ('O', 0));
            else if(lightColor == 'O')
                updated.Add(key, ('R', 0));
            else if(lightColor == 'R' && timeInState == 4)
                updated.Add(key, ('G', 0));
            else 
                updated.Add(key, (lightColor, timeInState+1));
        }
        return updated;
    }

    private static Dictionary<int, (char LightColor, int timeInState)> GetTrafficLights(string road)
    {
        var trafficLights = new Dictionary<int, (char LightColor, int timeInState)>();
        var roadArr = road.ToCharArray();
        for (var i = 0; i < roadArr.Length; i++)
        {
            if(roadArr[i] == 'G' || roadArr[i] == 'O' || roadArr[i] == 'R')
                trafficLights.Add(i, (roadArr[i], 0));
        }
        return trafficLights;
    }

    private static HashSet<int> GetCarLocations(string road)
    {
        var roadArr = road.ToCharArray();
        var res = new HashSet<int>();
        for (var i = 0; i < roadArr.Length; i++)
        {
            if (roadArr[i] == 'C')
                res.Add(i);
        }
        return res;
    }
}