using System;

public static class Calculator
{
  public static double Execute(double num1, char op, double num2)
  {
    if(op == '+')
      return num1 + num2;
    if(op == '-')
      return num1 - num2;
    if(op == '/' && num2 != 0)
      return num1 / num2;
    if(op == '*')
      return num1 * num2;
    throw new ArgumentException();
  }
}