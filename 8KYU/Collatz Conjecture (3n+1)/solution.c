unsigned next(unsigned n) {
  return n % 2 == 0 ? n / 2 : 3 * n + 1;
}
unsigned hotpo(unsigned n) {

    unsigned c = 0;
    while(n != 1) {
      c++;
      n = next(n);
    }
    return c;
}