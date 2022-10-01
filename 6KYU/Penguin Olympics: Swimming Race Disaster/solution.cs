using System;
using System.Linq;

namespace Solution
{
    public class SwimmingRace
    {
        private static string GetRemainingRace(string snapshot)
        {
            var penguin = snapshot.IndexOf("p");
            return snapshot[(penguin+1)..];
        }

        private static int CalculateRemainingRaceTime(string lane) =>
            lane.Aggregate(0, (acc, i) => i == '-' ? acc + 1 : acc + 2);

        public static string CalculateWinners(string snapshot, string[] penguins)
        {
            var winners = snapshot.ToLower()
                                  .Split('|')
                                  .Where(l => !string.IsNullOrWhiteSpace(l))
                                  .Select(GetRemainingRace)
                                  .Select(CalculateRemainingRaceTime)
                                  .Zip(Enumerable.Range(0, penguins.Length))
                                  .OrderBy(c => c.First)
                                  .Take(3)
                                  .Select(x => x.Second)
                                  .ToArray();
            
            return $"GOLD: {penguins[winners[0]]}, SILVER: {penguins[winners[1]]}, BRONZE: {penguins[winners[2]]}";
        }
    }
}