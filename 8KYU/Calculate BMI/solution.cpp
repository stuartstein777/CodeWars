#include <iostream>

std::string bmi(double w, double h) 
{
  
  const double bmi = (w / (h * h));
  std::cout << bmi;
  if (bmi <= 18.50005)
    return "Underweight";
  if (bmi <= 25.00005)
    return "Normal";
  if (bmi <= 30.00005)
    return "Overweight";
  
  return "Obese";
}