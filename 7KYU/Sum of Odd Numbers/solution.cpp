long long rowSumOddNumbers(unsigned n){
  long last = (n * n) + (n - 1);
  long start = last - (2 * (n - 1));
  return ((start + last) / 2) * n;
}