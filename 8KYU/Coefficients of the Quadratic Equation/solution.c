void quadratic(int x1, int x2, int coefficients[3]) {
  coefficients[0] = 1;
  coefficients[1] = -x2 - x1;
  coefficients[2] = -x1 * -x2;
}