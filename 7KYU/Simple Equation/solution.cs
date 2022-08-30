namespace Equation {

using System;
using System.Collections.Generic;
using System.Linq;

    public class Kata
    {
        public static string SolveTheEquation(string equation)
        {
           var splits = equation.Split(' ');
           var a = Double.Parse(splits[2]);
           var b = Double.Parse(splits[4]);
           var c = Solve(a, b, splits[1]);
          // spec says two decimal places, but there are tests 
          // that expect no decimals if its a whole number...
           return (c % 1 == 0) ? $"x = {c}" : $"x = {c:0.00}";           
        }
      
        private static double Solve(double a, double b, string f)
        {
            switch(f)
            {
                case "+":
                   return b - a;
                case "*":
                   return b / a;
                case "/":
                   return b * a;
                case "-":
                   return b + a;
            }
          
            throw new ArgumentException();
        }
    }
}