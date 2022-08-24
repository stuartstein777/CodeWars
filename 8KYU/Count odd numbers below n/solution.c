long odd_count(long n) {
  if (n % 2 == 0)
    return n/2;
  return (n-1)/2;
}