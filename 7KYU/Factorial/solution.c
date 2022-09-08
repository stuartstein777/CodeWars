unsigned __int128 factorial(unsigned n)
{
    __int128 res = 1;
  
    for(unsigned i = 1; i <= n; i++)
    {
      res *= i;
    }
    return res;
}