using System.Collections.Generic;
using System;
public class Kata
{
  private static Dictionary<char, Func<double, double, double>> _operations =
        new Dictionary<char, Func<double, double, double>>
          {
            {'+', (double a, double b) => a + b},
			{'-', (double a, double b) => a - b},
			{'*', (double a, double b) => a * b},
			{'/', (double a, double b) => a / b},
          };
  public static double Calculator(double a, double b, char op)
  {
    return _operations.ContainsKey(op)
				? _operations[op](a,b)
				: throw new ArgumentException(nameof(op));
  }
}