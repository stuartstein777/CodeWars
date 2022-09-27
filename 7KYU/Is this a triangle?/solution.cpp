namespace Triangle
{
  bool isTriangle(int a, int b, int c)
  {
      return long(a) + long(b) > c &&
             long(a) + long(c) > b &&
             long(b) + long(c) > a;
  }
};