using System;
using System.Collections.Generic;
public class Kata
{
    private static Dictionary<string, Func<double, double, double>> Ops =
        new Dictionary<string, Func<double, double, double>>
        {
            { "multiply", (a, b) => a * b },
            { "add", (a, b) => a + b },
            { "subtract", (a, b) => a - b },
            { "divide", (a, b) => a / b }
        };
    public static double Arithmetic(double a, double b, string op) => Ops[op](a,b);
}