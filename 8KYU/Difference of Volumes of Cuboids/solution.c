int volume(const int c[3]) {
  return c[0] * c[1] * c[2];
}

int find_difference(const int a[3], const int b[3]) {
    int av = volume(a);
    int bv = volume(b);
    return abs(av-bv);
}