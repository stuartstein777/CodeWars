using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

public class Dinglemouse
{
    public static string[] TrafficLights(string road, int n)
    {
        var trafficLights = GetTrafficLights(road);
        var cars = GetCarLocations(road);
        var roads = new List<string> {road};
        for (var i = 0; i < n; i++)
        {
            trafficLights = UpdateTrafficLights(trafficLights);
            cars = UpdateCarLocations(cars, trafficLights);
            roads.Add(BuildRoad(cars, trafficLights, road.Length));
        }
        return roads.ToArray();
    }

    public static string BuildRoad(
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
    
    /*
     * If the cars are one space from a traffic light, e.g.
     * 012345
     * ..CG..
     * then it can only advance if the light is green. Otherwise car can't advance.
     * Car can't advance if their is a car in front of the car that isn't moving either.
     * ..CCR...
     */
    public static HashSet<int> UpdateCarLocations(
        HashSet<int> cars,
        Dictionary<int, (char LightColor, int TimeInState)> trafficLights)
    {
        var updatedCars = new HashSet<int>();
        foreach (var car in cars)
        {
            // if car is 1 less than location of a traffic light or a car
            // and the traffic light isn't green. Car can't advance
            
            // If we are blocked by a car, can't advance.
            if (cars.Contains(car + 1))
                updatedCars.Add(car);
            // If its a traffic light that is the next square, and its not green, can't advance
            else if (trafficLights.ContainsKey(car + 1) &&
                     trafficLights[car + 1].LightColor != 'G')
                updatedCars.Add(car);
            // not blocked by car or an orange or red traffic light, car can advance.
            else 
                updatedCars.Add(car + 1);
        }

        return updatedCars;
    }
    
    public static Dictionary<int, (char LightColor, int TimeInState)> UpdateTrafficLights(
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
    
    public static Dictionary<int, (char LightColor, int timeInState)> GetTrafficLights(string road)
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

    public static HashSet<int> GetCarLocations(string road)
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