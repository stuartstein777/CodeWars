using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
    {
        return population.Select(c => new ChromosomeWrap { Chromosome = c, Fitness = fitness(c) });
    }
}