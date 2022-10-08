int sum(const int *values, int start, int end) {
  int total = 0;
  for(int i = start; i < end; i++) {
     total = total + values[i];
  }
  return total;
}

int find_even_index(const int *values, int length) {
  for(int n = 0; n < length; n++) {
    int l = sum(values, 0, n);
    int r = sum(values, n+1, length);
    if(l == r)
      return n;
  }
  return -1;
}