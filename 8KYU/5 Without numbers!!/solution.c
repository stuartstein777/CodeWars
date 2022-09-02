int unusual_five()
{
  int one = sizeof(char);
  int i = sizeof(int);
  unsigned int mask = sizeof(char);
  while (i & mask)
  {
    i &= ~mask;
    mask <<= one;
  }
  i |= mask;
  return i;
}