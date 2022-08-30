/*    N.B. do not allocate memory,
   instead: return a string literal  */

char *bmi(int weight, double height) {

  double bmi = (weight / (height * height));
  if (bmi <= 18.5)
    return "Underweight";
  if (bmi <= 25.0)
    return "Normal";
  if (bmi <= 30)
    return "Overweight";
  
  return "Obese";
}